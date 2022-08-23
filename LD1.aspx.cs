using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace LD1
{
    public partial class LD1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Button1_Click. Firstly, method prints my initial data. Then we call our recursion to repeat the action.
        /// Also we print how many rooms are in the matrix.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string path = Server.MapPath("App_Data/U3.txt");
            DataContainer data = InOut.ReadMaze(path);

            string rez = Server.MapPath("App_Data/U3rez.txt");
            if(File.Exists(rez))
            {
                File.Delete(rez);
                InOut.Print(data, rez);
            }
            
            

            TableRow rowData0 = new TableRow();
            TableCell celData0 = new TableCell();
            celData0.Text = Convert.ToString(data.GetLength(0));
            rowData0.Cells.Add(celData0);

            Table1.Rows.Add(rowData0);

            TableRow rowData1 = new TableRow();
            TableCell cellData1 = new TableCell();
            cellData1.Text = Convert.ToString(data.GetLength(1));
            rowData1.Cells.Add(cellData1);

            Table1.Rows.Add(rowData1);

            for (int i = 0; i < data.GetLength(0); i++)
            {
                TableRow rowMatrix = new TableRow();

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    TableCell cellMatrix = new TableCell();
                    cellMatrix.Text = Convert.ToString(data.Get(i,j));
                    rowMatrix.Cells.Add(cellMatrix);
                }
                Table1.Rows.Add(rowMatrix);
            }

            for (int i = 0; i < data.GetLength(0); i++)
            {
                TableRow rowMatrix = new TableRow();

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    TableCell cellMatrix = new TableCell();
                    cellMatrix.Text = Convert.ToString(data.Get(i, j));
                    rowMatrix.Cells.Add(cellMatrix);
                }
                Table2.Rows.Add(rowMatrix);
            }

            //-------------------------------------------------------------------------

            int rooms = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data.Get(i, j) != -1)
                    {
                        TaskUtils.Rekursija(i, j, data);
                        rooms++;
                    }
                }
            }

            TableRow rowRooms = new TableRow();
            TableCell cellRooms = new TableCell();
            cellRooms.Text = "Kambarių kiekis: " + Convert.ToString(rooms);
            rowRooms.Cells.Add(cellRooms);

            Table3.Rows.Add(rowRooms);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Table1.Rows.Clear();
            Table2.Rows.Clear();
            Table3.Rows.Clear();
        }
    }
}