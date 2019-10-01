using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20191001
{
    public partial class VisaBil : Form
    {
        public VisaBil()
        {
            InitializeComponent();

            label1.Text = "Bilar i lager";
            button1.Text = "Visa bilar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bilar b in MyCars)
            {

            }
        }
    }
}
