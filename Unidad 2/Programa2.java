/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa2 {//paso 1

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in); 
        int a, b, suma;//paso 2 declarar variables
        System.out.print("Escribe un número A: ");
        a = sc.nextInt(); 
        System.out.print("Escribe un número B: ");
        b = sc.nextInt(); 
        suma=a+b;
        System.out.println("Resultado: "+suma);
    }
}
