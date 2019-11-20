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

            cambio(27.50);
            Console.ReadKey();
        }
        static void cambio(double dolares)
        {
            int billeta10 = (int)dolares / 10;
            Console.WriteLine("(0) billetes de 10 dolares", billeta10);

            int billete5 = ((int)dolares % 10);
            Console.WriteLine("(0) Billete(s) de 5 dolares", billete5);

            int billete1 = ((int)dolares % 10) % 5;
            Console.WriteLine("(0) billete(s) de 1 dolar", billete1);

            /*int centavos50 = ();
            Console.WriteLine("");*/

        }
    }
}
