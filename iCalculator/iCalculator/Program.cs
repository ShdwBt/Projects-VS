using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalculator
{
    interface iCalculator
    {
        double Add();
        double Multiply();
        double Substract();
        double Divide();
    }

    interface iElectricity
    {
        void Charger();
    }


    public class Calculatrice : iCalculator, iElectricity
    {
        public double Add()
        {
            throw new NotImplementedException();
        }

        public double Multiply()
        {
            throw new NotImplementedException();
        }

        public double Substract()
        {
            throw new NotImplementedException();
        }

        public double Divide()
        {
            throw new NotImplementedException();
        }

        public void Charger()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
