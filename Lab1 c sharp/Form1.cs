﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_c_sharp
{
    public partial class Form1 : Form
    {
        Vector vector1;
        Vector vector2;
        Vector vector3;
        public Form1()
        {

            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                vector1 = new Vector(Convert.ToDouble(textBoX1.Text/* == "" ? "0" : textBoX1.Text*/),
                    Convert.ToDouble(textBoY1.Text/* == "" ? "0" : textBoY1.Text*/),
                    Convert.ToDouble(textBoZ1.Text/* == "" ? "0" : textBoZ1.Text*/));
                vector2 = new Vector(Convert.ToDouble(textBoX2.Text/* == "" ? "0" : textBoX2.Text*/),
                    Convert.ToDouble(textBoY2.Text/* == "" ? "0" : textBoY2.Text*/),
                    Convert.ToDouble(textBoZ2.Text/* == "" ? "0" : textBoZ2.Text*/));
                vector3 = new Vector(Convert.ToDouble(textBoX3.Text/* == "" ? "0" : textBoX3.Text*/),
                    Convert.ToDouble(textBoY3.Text/* == "" ? "0" : textBoY3.Text*/),
                    Convert.ToDouble(textBoZ3.Text/* == "" ? "0" : textBoZ3.Text*/));
                Vector r = (vector1 * vector2);
                r *= 2;
                Vector d = (vector1 + vector3) * r;
                richTextBoxVector.Text = vector1.ToString() + "\n" + vector2.ToString() + "\n" + vector3.ToString() +
    "\nr = 2 * (a + b) x c;\tr = " + r.ScalarProduct(r, vector3) + "\nd = (a + c) * r;\td = " + d;
            }
            catch
            {
                MessageBox.Show("Вы ввели не все координаты или же ввели их некорректно. Повторите попытку");
            }

        }
    }
}
