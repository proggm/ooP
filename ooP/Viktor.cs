using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ooP.Program;

namespace ooP
{
    internal class Viktor : Coding
    {
        public int modelVideo { get; set; }
        public int modelProc { get; set; }
        public int modelRam { get; set; }
        public override void Video()
        {
            Console.WriteLine($"gtx950");
        }
        public override void Proc()
        {
            Console.WriteLine($"i5-3470");
        }
        public override void Ramm()
        {
            Console.WriteLine($"ddr3");
        }
    }


}
