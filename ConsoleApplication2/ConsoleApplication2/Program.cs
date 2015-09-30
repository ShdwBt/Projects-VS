using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ligne = "";
            int[] tab = new int [5];
            string cmmd;
            int i = 0;
            String input;
            Boolean numero = false;

            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Quelle est votre valeur n°" + (i + 1) + "?");
                input = Console.ReadLine();

                while (!input.All(char.IsDigit))
                {
                    numero = false;
                    Console.WriteLine("Quelle est votre valeur n°" + (i + 1) + "?");
                    input = Console.ReadLine();
                    if (input.All(char.IsDigit))
                    {
                        numero = true;
                        tab[i] = int.Parse(input);
                    }

                } while (numero)
                {
                    //tab[i] = int.Parse(input);
                    i++;
                }
            }

             /* public static Boolean isAlphaNumeric(string strToCheck){
                    Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
                    return rg.IsMatch(strToCheck);
                } */


            /* for (i = 0; i < tab.Length; i++){
                Console.WriteLine("Quelle est votre valeur n°" + (i + 1) + "?");
                input = Console.ReadLine();
                while (numero){
                    while (!input.All(char.IsDigit)){
                        Console.WriteLine("Quelle est votre valeur n°" + (i + 1) + "?");
                        input = Console.ReadLine();
                    }
                    numero = true;
                } tab[i] = int.Parse(input);
                
            } */
            
                
                
               /* while (numero){
                    if (input.All(char.IsDigit)){
                    tab[i] = int.Parse(input);
                    }
                }
                
                Console.WriteLine("Quelle est votre valeur n°" + (i + 1) + "?");
                input = Console.ReadLine();

                if (input.All(char.IsDigit))
                {
                   
                    tab[i] = int.Parse(input);
                }
                else
                {
                 while (numero == false)
                    {

                          if (input.All(char.IsDigit))
              
                          
                          { 
                              Console.WriteLine("Entrez un nombre...");
                        Console.WriteLine("Quelle est votre valeur n°" + (i + 1) + "?");
                        Console.ReadLine();}
                     else
                        numero = true;
                   
                    tab[i] = int.Parse(input);
                }
                else
                {
                      
                    }
                 
                }

                numero = false;
            } */

            do {
                Console.WriteLine("Quelle est votre commande, 'S' pour sort et 'R' pour reverse, 'Q' pour quit ?");
                cmmd = Console.ReadLine();
                switch (cmmd)
               {
                    case "s":
                        Array.Sort(tab);
                         for (i = 0; i < tab.Length; i++)
                            {
                                Console.WriteLine("Element n° " + (i+1) + " est " + tab[i]);
                            }
                        break;
                    case "r" :
                         Array.Reverse(tab);
                         for (i = 0; i < tab.Length; i++)
                             {
                                 Console.WriteLine("Element n° " + (i+1) + " est "+ tab[i]);
                             }
                         
                         break;
                    default :
                         Console.WriteLine("Entrez les commandes adéquates...");
                            break;
                }
 

            }while(cmmd != "q");
        }
    }
}
