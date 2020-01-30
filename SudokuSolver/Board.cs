using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace SudokuSolver
{
    public class Board
    {
        public Line[] Rows { get; set; }

        public Line[] Columns { get; set; }

        public Line[] Subgrids { get; set; }

        public Cell[] Cells { get; set; }

        public Board(int[][] puzzle)
        {
            for (int rowNum = 0; rowNum < 9; rowNum++)
            {
                Rows[rowNum] = Rows[rowNum] ?? new Line();
                for (int colNum = 0; colNum < 9; colNum++)
                {
                    int subgridId = Board.getSubgridId(colNum, rowNum);
                    Subgrids[subgridId] = Subgrids[subgridId] ?? new Line();

                    int value = puzzle[rowNum][colNum];
                    Columns[colNum] = Rows[colNum] ?? new Line();

                    var cell = new Cell(value, Rows[rowNum], Columns[colNum], Subgrids[subgridId]);
                    Rows[rowNum].addCell(cell);
                    Columns[colNum].addCell(cell);
                    Subgrids[subgridId].addCell(cell);
                    Cells.Append(cell);
                }
            }
        }

        private static int getSubgridId(int column, int row)
        {
            return Convert.ToInt32(Math.Floor((double)column / 3) + Math.Floor((double)row / 3) * 3);
        }
    }

    public class Line
    {
        public Cell[] Cells { get; set; }

        public void addCell(Cell cell)
        {
            throw new NotImplementedException();
        }
    }

    public class Cell
    {
        public Cell(int value, Line row, Line column, Line subgrid)
        {
            throw new NotImplementedException();
        }
    }
}