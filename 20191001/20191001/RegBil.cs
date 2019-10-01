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
    public partial class RegBil : Form
    {
        public RegBil()
        {
            InitializeComponent();

            label1.Text = "Registrerings nummer";
            label2.Text = "Märke";
            label3.Text = "Modell";
            label4.Text = "Kilometer";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
