using System;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese los precios de los tres productos con IVA incluido
            Console.WriteLine("Ingrese el precio del primer producto con IVA incluido:");
            double precioProducto1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del segundo producto con IVA incluido:");
            double precioProducto2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del tercer producto con IVA incluido:");
            double precioProducto3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el IVA (el iva es generalmente el 16% en muchos países, puedes ajustarlo si es diferente)
            double porcentajeIVA = 0.16; // 16%
            double ivaProducto1 = precioProducto1 * porcentajeIVA;
            double ivaProducto2 = precioProducto2 * porcentajeIVA;
            double ivaProducto3 = precioProducto3 * porcentajeIVA;

            // Calcular el subtotal (precio sin IVA)
            double subtotalProducto1 = precioProducto1 - ivaProducto1;
            double subtotalProducto2 = precioProducto2 - ivaProducto2;
            double subtotalProducto3 = precioProducto3 - ivaProducto3;

            // Calcular el total (suma de los precios con IVA incluido)
            double total = precioProducto1 + precioProducto2 + precioProducto3;

            // Mostrar los resultados
            Console.WriteLine($"El IVA del primer producto es: {ivaProducto1}");
            Console.WriteLine($"El IVA del segundo producto es: {ivaProducto2}");
            Console.WriteLine($"El IVA del tercer producto es: {ivaProducto3}");
            Console.WriteLine($"El subtotal del primer producto es: {subtotalProducto1}");
            Console.WriteLine($"El subtotal del segundo producto es: {subtotalProducto2}");
            Console.WriteLine($"El subtotal del tercer producto es: {subtotalProducto3}");
            Console.WriteLine($"El total de los tres productos es: {total}");

            // Esperar a que el usuario presione Enter antes de cerrar la aplicación
            Console.ReadLine();
        }
    }
}