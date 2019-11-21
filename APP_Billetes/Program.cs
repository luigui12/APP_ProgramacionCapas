using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            cambio(27.50);
            Console.ReadKey();//pausa
        }

        static void cambio(double dolares)
        {
            int billeta10 = (int)dolares / 10;
            Console.WriteLine("(0) billetes de 10 dolares", billeta10);

            int billete5 = ((int)dolares % 10);
            Console.WriteLine("(0) Billete(s) de 5 dolares", billete5);

            int billete1 = ((int)dolares % 10) % 5;
            Console.WriteLine("(0) billete(s) de 1 dolar", billete1);
        }
    }
}
