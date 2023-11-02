/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa26__u3;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa26__U3 {

    public static void main(String[] args) {
        int c = 1;
        double salario = 1000.0; 
        double suma = 0.0;

        while (c <= 6) {
           
            salario = salario + 100; 


            System.out.println("Tu salario mensual del año " + c + " es: " + salario);


            double sueldoAnual = salario * 12;

       
            System.out.println("Tu salario del año " + c + " es: " + sueldoAnual);

     
            suma = suma + sueldoAnual;

         
            c++;
        }

        
        System.out.println("Tu sueldo acumulado por 6 años es: " + suma);

        
    }
}
