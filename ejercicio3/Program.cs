using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (edad>=13 && edad <=17)
            {
                Console.WriteLine("Eres un adolescente");
            }
            else 
            {
                Console.WriteLine("No Eres un adolescente");
            }

        }
    }
}
