using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_Oef4
{
    class Rechthoek
    {
        private double lengte;
        private double breedte;

        public double Lengte
        {
            get {
                if (lengte < 1)
                {
                    Exception e = new ArgumentException("De lengte was kleiner dan 1, de lengte word nu ingesteld op 5");
                    return 5;
                }
                else
                {
                    return lengte;
                }

            }
            set { lengte = value; }
        }
        public double Breedte
        {
            get
            {
                if (breedte < 1)
                {
                    Exception e = new ArgumentException("De breedte was kleiner dan 1, de breedte word nu ingesteld op 5");
                    return 5;
                }
                else
                {
                    return breedte;
                }
            }
            set
            {
                breedte = value;
            }
        }
        public double Oppervlakte()
        {
            return Lengte * Breedte;
        }

    }
}
