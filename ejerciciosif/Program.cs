using System;

namespace ejerciciosif
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if(edad==15)
            {
                Console.WriteLine("Quinceañero");
            }
            else
            {
                Console.WriteLine("No eres Quinceañero");
            }
            Console.ReadKey();
        }
    }
}
