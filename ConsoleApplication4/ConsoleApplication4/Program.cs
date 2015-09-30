using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    public class Employee
    {
        //private int m_id;

        public Employee()
        {
            Console.WriteLine("Constructeur par défaut d'Employee");
        }

        ~Employee()
        {
            Console.WriteLine("Destructeur d'Employee");
        }

        //public Employee(int id)
        //{
        //    Console.WriteLine("Constructeur avec paramètre d'Employee");
        //    m_id = id;
        //}
        public void DoWork()
        {
            Console.WriteLine("L'employee travaille");
        }
    }

    public class Manager : Employee
    {
        public Manager() //: base(12) // avec l'id du 2eme constructeur d'Employee
        {
            Console.WriteLine("Constructeur par défaut de Manager");
        }
        
        ~Manager()
        {
            Console.WriteLine("Destructeur de Manager");
        }

        public new void DoWork() //Redéfinition de la méthode avec le mot clé new
        {
            Console.WriteLine("Le manager travaille");
        }
    }

    public class ManualWorker : Employee
    {
        public ManualWorker() //: base(5) // avec l'id du 2eme constructeur d'Employee
        {
            Console.WriteLine("Constructeur par défaut de ManualWorker");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début AppelMethode");

        }

        public static void AppelMethode()
        {
            Employee emp1 = new Employee();
            //Employee emp2 = new Employee();

            //Employee myEmployee = new Employee();
            //Manager myManager = myEmployee as Manager;

            //emp1.DoWork();
            //emp2.DoWork();

            //Manager ma1 = new Manager();
            //ma1.DoWork();
            //ManualWorker manu1 = new ManualWorker();

            Console.WriteLine("The END");
            Console.ReadLine();
        }
    }
}
