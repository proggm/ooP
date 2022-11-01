using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooP
{
    internal class Raziyat : Coding
    {
        public int modelVideo { get; set; }
        public int modelProc { get; set; }
        public int modelRam { get; set; }
        public override void Video()
        {
            Console.WriteLine($"gtx1050ti");
        }
        public override void Proc()
        {
            Console.WriteLine($"i5-7500");
        }
        public override void Ramm()
        {
            Console.WriteLine($"ddr4");
        }
    }
}
