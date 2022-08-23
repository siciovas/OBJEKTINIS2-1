using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace LD1
{
    public class InOut
    {
        /// <summary>
        /// A method "ReadMaze" reads all symbols in the .txt file.
        /// </summary>
        /// <param name="fileName">Current file name</param>
        /// <returns>A method "ReadMaze" returns full matrix</returns>
        public static DataContainer ReadMaze(string fileName)
        {
            string line;

            using (StreamReader reader = new StreamReader(fileName))
            {
                line = reader.ReadLine();
                int X = Convert.ToInt32(line);

                line = reader.ReadLine();
                int Y = Convert.ToInt32(line);

                DataContainer Data = new DataContainer(X, Y);

                for (int i = 0; i < X; i++)
                {
                    line = reader.ReadLine();
                    string[] parts = line.Split(' ');

                    for (int j = 0; j < Y; j++)
                    {
                        Data.Add(Convert.ToInt32(parts[j]), i, j);
                    }
                }
                return Data;
            }
        }

        public static void Print(DataContainer data, string fileName)
        {
            using(StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(data.GetLength(0));
                writer.WriteLine(data.GetLength(1));
                for(int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        writer.Write(data.Get(i, j).ToString() + " ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}