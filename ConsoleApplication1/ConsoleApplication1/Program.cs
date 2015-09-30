using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            long l = 1;
            a = (int)l;

            for (a = 0; a < 5; a++)
            {
                Console.WriteLine("Hello World");

                Console.Read();
            }
        }
    }
}
