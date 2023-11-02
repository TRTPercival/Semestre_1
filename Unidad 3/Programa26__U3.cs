
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa26_U3
{

    public static void Main(String[] args)
    {
        int c = 1;
        double salario = 1000.0;
        double suma = 0.0;

        while (c <= 6)
        {

            salario = salario + 100;


            Console.WriteLine("Tu salario mensual del año " + c + " es: " + salario);


            double sueldoAnual = salario * 12;


            Console.WriteLine("Tu salario del año " + c + " es: " + sueldoAnual);


            suma = suma + sueldoAnual;


            c++;
        }


        Console.WriteLine("Tu sueldo acumulado por 6 años es: " + suma);


    }
}
