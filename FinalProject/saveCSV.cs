using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject
{
    public class saveCSV
    {
        public bool Export(DataGridView dgv)
        {
            bool exported = false;
            bool firstDone = false;

            List<string> lines = new List<string>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                StringBuilder dataLine = new StringBuilder();
                firstDone = false;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {
                        dataLine.Append("," + cell.Value);
                    }
                }
                lines.Add(dataLine.ToString());
            }
            string file = "data.csv";
            System.IO.File.WriteAllLines(file, lines);
            System.Diagnostics.Process.Start(file);

            return exported;

        }
    }
}
