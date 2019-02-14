using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef4
{
    class Driehoek
    {
        private double basis;
        private double hoogte;
        public double Basis
        {
            get
            {
                if (basis < 1)
                {
                    Exception e = new ArgumentException("De basis was kleiner dan 1, deze zal nu verandert worden naar 5");
                    return 5;
                }
                else
                {
                    return basis;
                }
            }
            set
            {
                basis = value;
            }
        }
        public double Hoogte
        {
            get
            {
                if (hoogte < 1)
                {
                    Exception e = new ArgumentException("De hoogte was kleiner dan 1, deze zal nu verandert worden naar 5");
                    return 5;
                }
                else
                {
                    return hoogte;
                }
            }
            set
            {
                hoogte = value;
            }
        }
        public double ToonOppervlakte()
        {
            return Hoogte* Basis;
        }
    }
}
