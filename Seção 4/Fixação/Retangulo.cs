using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Fixação
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "ÁREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\r\n" + "PERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\r\n" + "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}