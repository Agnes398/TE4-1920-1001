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
        System.Collections.ArrayList MyCars = new System.Collections.ArrayList();
        public RegBil()
        {
            InitializeComponent();

            label1.Text = "Registrerings nummer";
            label2.Text = "Märke";
            label3.Text = "Modell";
            label4.Text = "Kilometer";

            button1.Text = "Registrera";
            button2.Text = "Klar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCars.Add(new Bilar() { RegNum = textBox1.Text, Märke = textBox2.Text, Modell = textBox3.Text, Km = textBox4.Text });
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
