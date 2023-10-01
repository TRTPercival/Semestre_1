using System;

namespace Programa8
{
    class Hexagono
    {
        static void Main(string[] args)
        {
            int Lado, Perímetro, Apótema, Área;
            Console.WriteLine("Introducir valor de un lado del hexagono");
            Lado = Convert.ToInt32(Console.ReadLine());
            Perímetro = Lado * 6;
            Console.WriteLine("Introducir valor del Apótema");
            Apótema = Convert.ToInt32(Console.ReadLine());
            Área = (Perímetro * Apótema) / 2;
            Console.WriteLine("El Área es igual a :" + Área);          

        }
    }
}