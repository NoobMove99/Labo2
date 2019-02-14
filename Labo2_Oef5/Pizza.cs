using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef5
{
    class Pizza
    {
        private string topppings;
        private int diameter;
        private double prijs;

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("De opgegeven diameter was te klein, deze word nu op 5 gezet");
                    diameter = 5;
                }
                else
                {
                    diameter = value;
                }
            }
        }
        public string Toppings
        {
            get
            {
                return topppings;
            }
            set
            {
                topppings = value;
            }
        }
        public double Prijs
        {
            get
            {
                return prijs;
            }
            set
            {
                prijs = value;
            }
        }
    }
}
