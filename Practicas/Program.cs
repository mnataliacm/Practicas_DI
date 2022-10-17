using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    
    internal class Program
    {
        const string REPETIR_BUCLE = "S";
        const string NO_REPETIR_BUCLE = "N";
        static void Main(string[] args)
        {
            Practica4();
            //Practica3();
            //Practica2();
            //Practica1();
        }


        #region Practica 4
        static void Practica4()
        {
            string respuesta = string.Empty;

            respuesta = LeerRespuesta();

            do
            {
                respuesta = LeerRespuesta();
            } while (String.Equals(respuesta, REPETIR_BUCLE));

            Console.WriteLine("Has salido del bucle");
        }
        static string LeerRespuesta() 
        {
            string respuesta = string.Empty;
            Console.WriteLine("¿Quieres entrar al bucle? (S/N)");
            respuesta = Console.ReadLine().ToUpper();
            do
            {
                Console.WriteLine("Debes introducir N o S");
                respuesta = Console.ReadLine().ToUpper();
            } while(!respuesta.Equals(NO_REPETIR_BUCLE) && !respuesta.Equals(REPETIR_BUCLE));

            return respuesta;
        }
        #endregion

        #region Practica 3
        //mejor hacer como está la practica 4
        static void Practica3()
        {
            
            string respuesta = string.Empty;
            int c = 0;

            while (string.IsNullOrEmpty(respuesta))
            {
                Console.WriteLine("¿Quieres entrar al bucle? (S/N)");
                respuesta = LeerRespuesta(Console.ReadLine().ToUpper());
            }

            while (string.Equals(respuesta, REPETIR_BUCLE))
            {
                c++;
                Console.WriteLine("¿Quieres entrar al bucle de nuevo (" + c + ") ? (S/N)");
                respuesta = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Has salido del bucle");     
        }

        private static string LeerRespuesta(string r)
        {
            if ((string.Equals(r, "S") || (string.Equals(r, "N"))))
            {
                return r;
            }
            else
            {
                Console.WriteLine("La respuesta solo puede ser 'S' o 'N', vuelve a intentarlo");
                return null;
            }
        }
        #endregion

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
                if (String.Equals(carnet, TIENE_CARNET))
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
