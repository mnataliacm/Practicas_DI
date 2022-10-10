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
            Practica1();
        }



        #region Practica 2



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
