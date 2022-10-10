using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practica2();
            //Practica1();
        }



        #region Practica 2
        static void Practica2()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad, por favor: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= PUEDE_CONDUCIR)
            {
                Console.WriteLine("¿Tienes carnet? (S/N): ");
                string carnet = Console.ReadLine().ToUpper();
                if (string.Equals(carnet, TIENE_CARNET))
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("No puedes conducir");
                }
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
        #endregion

        #region Practica 1
        static void Practica1()
        {
            Console.WriteLine("Inroduce un radio: ");
            int num1 = int.Parse(Console.ReadLine());
            const double PI = 3.14;
            double area = PI * Math.Pow(num1, 2);
            Console.WriteLine($"El área del círculo con un radio de: {num1} vale {area}");
        }
        #endregion
    }
}
