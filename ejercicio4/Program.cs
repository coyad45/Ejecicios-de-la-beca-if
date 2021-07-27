using System;

namespace ejercicio4
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
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Eres un adolescente");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}
