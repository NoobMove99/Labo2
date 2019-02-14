using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();
            Rechthoek rechthoek2 = new Rechthoek();
            Driehoek driehoek1 = new Driehoek();
            Driehoek driehoek2 = new Driehoek();

            rechthoek1.Breedte = 0.5;
            rechthoek1.Lengte = 6;
            rechthoek2.Breedte = 9;
            rechthoek2.Lengte = 10;
            driehoek1.Basis = 7;
            driehoek1.Hoogte = 0.5;
            driehoek2.Basis = 8;
            driehoek2.Hoogte = 9;
            Console.WriteLine(rechthoek1.ToonOppervlakte());
            Console.WriteLine(rechthoek2.ToonOppervlakte());
            Console.WriteLine(driehoek1.ToonOppervlakte());
            Console.WriteLine(driehoek2.ToonOppervlakte());
            Console.ReadKey();

        }
    }
}
