using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Conversor_De_Moeda
{
    public class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double Conversor(double reais, double dolares) {
            return reais * dolares * IOF + reais * dolares;
        }

    }
}