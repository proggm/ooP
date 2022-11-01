using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooP
{
    internal class Magomed : Program.Coding
    {
        public int modelVideo { get; set; }
        public int modelProc { get; set; }
        public int modelRam { get; set; }

        public override void Video()
        {
            Console.WriteLine($"gtx3060ti");
        }
        public override void Proc()
        {
            Console.WriteLine($"i9-9900k");   
        }
        public override void Ramm()
        {
           Console.WriteLine($"ddr5");
        }
    }
}
