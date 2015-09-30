using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Int32[] tabInt = new Int32[100000000008];
                int a = 5;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Suite su programme !");
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Mémoire insuffisante !");
                Console.ReadLine();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division par 0 attrapée !");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Super Exception !");
                Console.ReadLine();
            }
        }
    }
}
