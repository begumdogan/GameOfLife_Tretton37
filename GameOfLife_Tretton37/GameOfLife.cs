using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife_Tretton37
{
    public partial class GameOfLife : Form
    {

        public int cellSize = 20;
        public int generationCount = 0;
        Grid objGrid;

        public GameOfLife()
        {
            InitializeComponent();

        }

        /* Events */

        private void GameOfLife_Load(object sender, EventArgs e)
        {
            objGrid = new Grid(MainLayout, 20, 25, cellSize);
        }
        private void btnStartGen_Click(object sender, EventArgs e)
        {
            generationTick.Start();
            btnStartGen.Enabled = false;

        }

        private void btnStopGen_Click(object sender, EventArgs e)
        {
            generationTick.Stop();
            btnStartGen.Enabled = true;
            if (btnStopGen.Text.StartsWith("Stop"))
            {
                btnStopGen.Text = "Terminate";
                ResetAll(true);
                txtPopulation.Text = CountPopulation().ToString();
                txtGeneration.Text = generationCount.ToString();
            }
            else
            {
                ResetAll(false);
                this.Close();
            }
        }

        private void ResetAll(bool state)
        {
            lblPopulation.Visible = state;
            txtPopulation.Visible = state;
            lblGeneration.Visible = state;
            txtGeneration.Visible = state;
            if (!state)
            {
                objGrid.ClearGrid();
                Cell.cellLookUp.Clear();

                txtGeneration.Text = String.Empty;
                txtPopulation.Text = String.Empty;
            }

        }
        private void generationTick_Tick(object sender, EventArgs e)
        {
            generationTick.Stop();
            if (CountPopulation() == 0)
            {
                generationTick.Stop();
                btnStartGen.Enabled = true;
            }
            else
            {
                CheckNeighbour();
                objGrid.UpdateGrid();
                generationCount += 1;
                generationTick.Start();
            }
        }


        /* Algorithmic */
        private void CheckNeighbour()
        {
            NextGeneration(GetNeighbour());
        }

        private void NextGeneration(Dictionary<Point, int> neighbourDict)
        {
            //check for neighbours 
            foreach (KeyValuePair<Point, int> item in neighbourDict)
            {
                if (item.Value < 2 || item.Value > 3)
                {
                    Cell.cellLookUp[item.Key] = false;  //isolation or overcrowded death
                }
                else if (item.Value.Equals(3) && Cell.cellLookUp[item.Key].Equals(false))
                {
                    Cell.cellLookUp[item.Key] = true;
                }
            }

        }

        private Dictionary<Point, int> GetNeighbour()
        {
            int neighbourCount = 0;
            foreach (KeyValuePair<Point, bool> item in Cell.cellLookUp)
            {
                neighbourCount = 0;
                try
                {   //if (item.Value.Equals(Cell.cellLookUp[new Point(item.Key.X, item.Key.Y + cellSize)]))                    
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X, item.Key.Y + cellSize))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X + cellSize, item.Key.Y + cellSize))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X + cellSize, item.Key.Y))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X + cellSize, item.Key.Y - cellSize))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X, item.Key.Y - cellSize))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X - cellSize, item.Key.Y - cellSize))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X - cellSize, item.Key.Y))])
                    {
                        neighbourCount += 1;
                    }
                    if (Cell.cellLookUp[objGrid.WrapEdges(new Point(item.Key.X - cellSize, item.Key.Y + cellSize))])
                    {
                        neighbourCount += 1;
                    }
                }
                catch
                {
                    neighbourCount = 0;
                }
                //TODO: when there is the key already
                if (!Cell.neighbourDict.ContainsKey(item.Key))
                {
                    Cell.neighbourDict.Add(item.Key, neighbourCount);
                }
                else
                {
                    Cell.neighbourDict[item.Key] = neighbourCount;
                }
            }
            return Cell.neighbourDict;

        }

        private int CountPopulation()
        {
            int population = 0;
            Dictionary<Point, bool> liveList = Cell.cellLookUp.Where(val => val.Value.Equals(true)).ToDictionary(i => i.Key, i => i.Value);
            population = liveList.Count;
            return population;

        }

    }
}
