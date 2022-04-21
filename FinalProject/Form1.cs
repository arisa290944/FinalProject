using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Text;
using NSubstitute.Core;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindData(string filePath)
        {

        }

        private void addMenu_btn_Click(object sender, EventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.FileName = "data.csv";

            car carInfo = new car();
            string[] carArray;

            DataTable dt = new DataTable();
            dt.Columns.Add("License Number", typeof(string));
            dt.Columns.Add("Brand", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Date-in", typeof(string));
            dt.Columns.Add("Time-in", typeof(string));
            dt.Columns.Add("Date-out", typeof(string));
            dt.Columns.Add("Time-out", typeof(string));

            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                while (!sr.EndOfStream)
                {
                    carArray = sr.ReadLine().Split(",");

                    carInfo.LN = carArray[0];
                    carInfo.Brand = carArray[1];
                    carInfo.Model = carArray[2];
                    carInfo.Color = carArray[3];
                    carInfo.DateIn = carArray[4];
                    carInfo.TimeIn = carArray[5];
                    carInfo.DateOut = carArray[6];
                    carInfo.TimeOut = carArray[7];

                    dt.Rows.Add(carArray);
                }
                DataView dv = new DataView(dt);
                dataGridView1.DataSource = dv;
            }
        }
     }
}
