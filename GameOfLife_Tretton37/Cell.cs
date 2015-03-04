using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife_Tretton37
{
    class Cell: Button
    {
        Point position;

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        bool isAlive;

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }

        private int cellSize;

        public int CellSize
        {
            get { return cellSize; }
            set { cellSize = value; }
        }

        public static Dictionary<Point, bool> cellLookUp = new Dictionary<Point, bool>();
        public static Dictionary<Point, int> neighbourDict = new Dictionary<Point, int>();

        public Cell() { }
        public Cell(Point position, int cellSize, bool isAlive) 
        {
            Position = position;
            IsAlive = isAlive;
            CellSize = cellSize;
            if (position != null)
            {
                this.Location = position;
            }
            this.Size = new Size(CellSize, CellSize);
            this.FlatStyle = FlatStyle.Flat;
            this.Margin = Padding.Empty ;
            this.BackColor = Color.White; 
            this.Dock = DockStyle.Fill;
            if (!cellLookUp.ContainsKey(this.Location))
            {
                cellLookUp.Add(this.Location, this.IsAlive);
            }
            else
            {
                cellLookUp[this.Location] = this.IsAlive;
            }
        }


    

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            
            if (this.BackColor == Color.White) 
            {
                this.BackColor = Color.Green;
                this.IsAlive = true;
                //neighbourLookUp.Add(this.Location, IsAlive);
                
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.White;
                this.IsAlive = false;
                //neighbourLookUp[this.Location] = IsAlive;
            }

            //cellLookUp = new Dictionary<Point, bool>();
            cellLookUp[this.Location] = IsAlive;

        }



    }
}
