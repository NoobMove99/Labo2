using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Resultaat Res = new Resultaat();
            Res.Graad = 55;
            Res.PrintGraad();
            Console.ReadLine();
        }
    }
}
