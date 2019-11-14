using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Prueba_Facto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            double res = APP_ProgramacionCapas.Factorial.fact(num);
            Console.WriteLine("El resulttado de : {0} es {1} ",num,res);
            Console.ReadKey();//pausa
        }
    }
}
