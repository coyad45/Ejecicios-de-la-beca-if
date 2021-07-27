using System;

namespace Ejercicio5
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

            if ((edad < 18) && (estadoC != "soltero")) 
            {
                Console.WriteLine("Es muy pequeño para No ser soltero");
            }
        }
    }
}
