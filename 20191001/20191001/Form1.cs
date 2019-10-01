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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "Välkommen!";
            label2.Text = "Vad vill du göra?";
            button1.Text = "Registrera ny bil";
            button2.Text = "Visa bilar i lager";
        }
    }
}
