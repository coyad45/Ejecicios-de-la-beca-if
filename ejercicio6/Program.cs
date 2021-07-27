using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string estadoC;
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estado civil");
            estadoC = Console.ReadLine();
            estadoC = estadoC.Trim();
            estadoC = estadoC.ToLower();

            if ((edad >= 18) && (estadoC == "soltero"))
            {
                Console.WriteLine("Es soltero y no es menor");
            }
        }
    }
}
