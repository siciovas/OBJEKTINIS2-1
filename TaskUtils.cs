using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LD1
{
    public static class TaskUtils
    {
        /// <summary>
        /// A method "Rekursija" checks all numbers that are in the matrix. Firstly, method checks if road have walls. Then 
        /// when we know how many wlls and where are they, we can travel and count how many rooms are in the matrix.
        /// </summary>
        /// <param name="x">X coordinate of the matrix</param>
        /// <param name="y">Y coordinate of the matrix</param>
        /// <param name="Data">Matrix</param>
        public static void Rekursija(int x, int y, DataContainer Data)
        {
            if (Data.Get(x, y) == -1)
                return;

            List<char> sienos = new List<char>();

            if (Data.Get(x, y) >= 8)
            {
                Data.Add(Data.Get(x, y) - 8, x, y); // Means they have a southern wall.
                sienos.Add('P');
            }

            if (Data.Get(x, y) >= 4)
            {
                Data.Add(Data.Get(x, y) - 4, x, y); // Means they have an eastern wall.
                sienos.Add('R');
            }

            if (Data.Get(x, y) >= 2)
            {
                Data.Add(Data.Get(x, y) - 2, x, y); // Means they have a northern wall.
                sienos.Add('S');
            }

            if (Data.Get(x, y) == 1)
            {
                Data.Add(Data.Get(x, y) - 1, x, y); // Means having a western wall.
                sienos.Add('V');
            }

            Data.Add(-1, x, y);

            if (!sienos.Contains('P'))
            {
                // Going south
                Rekursija(x + 1, y, Data);
            }

            if (!sienos.Contains('R'))
            {
                // Going east
                Rekursija(x, y + 1, Data);
            }

            if (!sienos.Contains('S'))
            {
                // Going north
                Rekursija(x - 1, y, Data);
            }

            if (!sienos.Contains('V'))
            {
                // Going west
                Rekursija(x, y - 1, Data);
            }
        }
    }
}