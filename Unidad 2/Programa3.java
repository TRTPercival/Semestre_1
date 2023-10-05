/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa3 {//paso 1

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in); 
        int c1, c2, c3, c4, c5, c6, prom;//paso 2 declarar variables
        System.out.print("Escribe tu primera calificacion: ");
        c1 = sc.nextInt(); 
        System.out.print("Escribe tu segunda calificacion: ");
        c2 = sc.nextInt(); 
         System.out.print("Escribe tu tercera calificacion: ");
        c3 = sc.nextInt(); 
        System.out.print("Escribe tu cuarta calificacion: ");
        c4 = sc.nextInt(); 
         System.out.print("Escribe tu quinta calificacion: ");
        c5 = sc.nextInt(); 
        System.out.print("Escribe tu sexta calificacion: ");
        c6 = sc.nextInt(); 
        prom= (c1+c2+c3+c4+c5+c6)/6;
        System.out.println("Resultado: "+prom);
    }
}
