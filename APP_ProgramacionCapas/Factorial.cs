using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_ProgramacionCapas
{
    public static class Factorial
    {
        /// <summary>
        /// Calcula factorial de un numemro
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static long fact(int num)
        {
            long f = 1;
            if (num == 0 || num == 1)
                return 1;
            for (int i=1;i<=num;i++) 
            {
                f = f * i;
            }
            return f;
        }
        /// <summary>
        /// Calcula el cuadrado de un numero
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double cuadrado(double num)
        {
            return (num*num);
        }

    }
}
