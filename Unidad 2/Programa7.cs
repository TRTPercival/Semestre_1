using System;

namespace Programa7
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            int x, y, suma, resta, multiplicación, división;
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("Ingrese el primer número:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            y = Convert.ToInt32(Console.ReadLine());
            suma = x + y;
            Console.WriteLine("La suma es igual a: " + suma);
            resta = x - y;
            Console.WriteLine("La resta es igual a: " + resta);
            multiplicación = x * y;
            Console.WriteLine("La multiplicación es igual a: " + multiplicación);
            división = x / y;
            Console.WriteLine("La división es igual a: " + división);
        }
    }
}