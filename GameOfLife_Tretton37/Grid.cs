using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife_Tretton37
{
    class Grid
    {
        private int layoutWidth = 0, layoutHeight = 0;
        private TableLayoutPanel tbl;
        private Cell c;

        public Grid(TableLayoutPanel tb, int row, int column, int cellSize)
        {            
            tbl = tb;
            tbl.Location = new Point(0, 0);
            tbl.RowCount = row;
            tbl.ColumnCount = column;
            layoutWidth = column * cellSize;
            tbl.Width = layoutWidth;
            layoutHeight = row * cellSize;
            tbl.Height = layoutHeight;
            tbl.Dock = DockStyle.None;
            for (int i = 0; i < column; i++)
            {
                ColumnStyle cs = new ColumnStyle(SizeType.Absolute, cellSize);
                tbl.ColumnStyles.Add(cs);

                for (int j = 0; j < row; j++)
                {
                    RowStyle rs = new RowStyle(SizeType.Absolute, cellSize);
                    tbl.RowStyles.Add(rs);
                    c = new Cell(new Point(i * cellSize, j * cellSize), cellSize, false);                                        
                    tbl.Controls.Add(c, i, j);
                    
                }
            }
        }

        public void ClearGrid()
        {
            IEnumerable<Cell> cells = tbl.Controls.OfType<Cell>();
            foreach (var item in cells)
            {
                item.BackColor = Color.White;
            }
        }

        public void UpdateGrid()
        { 
            ClearGrid();
            Dictionary<Point, bool> liveList = Cell.cellLookUp.Where(val => val.Value.Equals(true)).ToDictionary(i => i.Key, i => i.Value);

            foreach (KeyValuePair<Point, bool> item in liveList)
            {
                foreach (Cell cell in tbl.Controls)
                {

                    if (cell.Location == item.Key)
                    {
                        if (item.Value.Equals(true))
                        {
                            cell.BackColor = Color.Red;
                        }
                        else
                        {
                            cell.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        public Point WrapEdges(Point pNew)
        {
            //pNew = pOld;
            if (pNew.X < 0)
            {
                pNew.X += layoutWidth;
            }
            else if (pNew.X > layoutWidth - 1)
            {
                pNew.X -= layoutWidth;
            }

            if (pNew.Y < 0)
            {
                pNew.Y += layoutHeight;
            }
            else if (pNew.Y > layoutHeight - 1)
            {
                pNew.Y -= layoutHeight;
            }
            return pNew;
        }

    }
}
