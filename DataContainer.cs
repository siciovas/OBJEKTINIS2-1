using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LD1
{
    public class DataContainer
    {
        private int[,] Matrix;

        public DataContainer(int x, int y)
        {
            this.Matrix = new int[x, y];
        }

        public int Get(int x, int y)
        {
            return this.Matrix[x, y];
        }

        public void Add(int number, int x, int y)
        {
            this.Matrix[x, y] = number;
        }

        public int GetLength(int index)
        {
            return this.Matrix.GetLength(index);
        }
    }
}