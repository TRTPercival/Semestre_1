using System;

namespace Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese su edad:");

            // Leer la edad ingresada por el usuario
            int edad = Convert.ToInt32(Console.ReadLine());

            // Verificar si es mayor o menor de edad
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }

            
        }
    }
}