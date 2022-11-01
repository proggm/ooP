using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magomed mag = new Magomed();
            mag.Video();
            Console.ReadKey();
        }

        public class Coding { 
            public string Videocard { get; set; }
            public string Processor { get; set; }
            public byte Ram { get; set; }

            public virtual void Video()
            {
                Console.WriteLine("Я использую видеокарту Nvidia");
            }
            public virtual void Proc()
            {
                Console.WriteLine("Я использую процессор Intel");
            }
            public virtual void Ramm()
            {
                Console.WriteLine("У меня 12гб ОЗУ");
            }             
        }
        

    }
}
