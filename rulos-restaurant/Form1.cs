using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rulos_restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            userControl11.BringToFront();
        }

        /* Cambiar posicion de barra lateral y UserControls */
        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            userControl41.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            userControl51.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            userControl61.BringToFront();
        }
    }
}
