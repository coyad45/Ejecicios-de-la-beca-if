using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Felicidades eres mayor de edad");

            }
            else 
            {
                Console.WriteLine("Eres menor de edad");
            }
            Console.ReadKey();
        }
    }
}
