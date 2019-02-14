using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef2
{
    class Resultaat
    {
        public int Graad { get; set; }
        public void PrintGraad()
        {
            if (Graad < 50)
            {
                Console.WriteLine("Niet geslaagd");
            }
            else if (Graad >=50 && Graad <68)
            {
                Console.WriteLine("Voldoende");
            }
            else if (Graad>=68 && Graad< 75)
            {
                Console.WriteLine("Onderscheiding");
            }
            else if (Graad >=75 && Graad<85)
            {
                Console.WriteLine("Grote Onderscheiding");
            }
            else if (Graad>=85)
            {
                Console.WriteLine("Grootste Onderscheiding");
            }
        }
    }
}
