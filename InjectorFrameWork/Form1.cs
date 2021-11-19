using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InjectorFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = 0;
            // and another not equal to zero
            int p2 = 57;
            try
            {
                Console.Write(p2 / p1);
            }
            catch 
            {
                MessageBox.Show("Needs Injection Method", "Error");
            }

        }
    }
}
