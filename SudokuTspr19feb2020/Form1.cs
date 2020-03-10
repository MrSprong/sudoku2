using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuTspr19feb2020
{
    public partial class Form1 : Form
    {
        int rows = 0;
        int horizontalBlocks = 3;
        int verticalBlocks = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 480;
            Height = 700;
            for (int k = 0; k < verticalBlocks; k++)
            {
                for (int j = 0; j < horizontalBlocks; j++)
                {
                    for (int length = 0; length < 9; length++)
                    {
                        for (int width = 0; width < 9; width++)
                        {
                            TextBox t = new TextBox();
                            t.Width = 15;
                            t.Height = 15;
                            this.Controls.Add(t);
                            t.Left = (width * 16) + (j * 150);
                            t.Top = (rows * 20) + (k*200);
                        }
                        rows++;
                    }
                    rows = 0;
                }
            }
        }
    }
}
