using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_ProgramacionCapas
{
    public static class Ecuacion
    {
        /// <summary>
        /// Calcula la funcion de X1 y x2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static double X1(double a, double b, double c, out string msg)
        {
            msg = "";
            if (a == 0)
            {
                msg = "Error, division para 0...!!";
                return 0;
            }
            double d = (b * b) - (4 * a * b );
            if (d<0)
            {
                msg = "Raices negativas. La ecuacion tiene solucion imaginaria...";
                return 0;
            }
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }
        public static double X2(double a, double b, double c, out string msg)
        {
            msg = "";
            if (a == 0)
            {
                msg = "Error, division para 0...!!";
                return 0;
            }
            double d = (b * b) - (4 * a * b );
            if (d < 0)
            {
                msg = "Raices negativas. La ecuacion tiene solucion imaginaria...";
                return 0;
            }
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

    }

}
