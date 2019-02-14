using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nummers paar1 = new Nummers();
            paar1.Getal1 = 12;
            paar1.Getal2 = 34;

            Console.WriteLine("Paar:" + paar1.Getal1 + ", " + paar1.Getal2);
            Console.WriteLine("Som = " + paar1.Som());
            Console.WriteLine("Verschil = " + paar1.Verschil());
            Console.WriteLine("Product = " + paar1.Product());
            Console.WriteLine("Quotient = " + paar1.Quotient());
        }
    }
}
