using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Holamundo0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero para la realización de la figura");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; 0 < numero; i++)

            {
                for (int numero1 = 0; numero1 < i; numero1++) ;
                {
                    Console.WriteLine(" * ");
                }
                for (int numero1 = 0; numero1 < i; numero1++) ;
                {
                    Console.WriteLine(" * ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}


