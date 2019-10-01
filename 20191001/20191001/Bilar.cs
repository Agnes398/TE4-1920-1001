using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191001
{
    public class Bilar
    {
        public string RegNum { get; set; }
        public string Märke { get; set; }
        public string Modell { get; set; }
        public string Km { get; set; }

        public List<Bilar> MyCars = new List<Bilar>();


        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", RegNum, Märke, Modell, Km);
        }
    }
}
