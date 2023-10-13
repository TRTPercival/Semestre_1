/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.p13;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class P13 {

    public static void main(String[] args) {
        Scanner sc =new Scanner ( System.in);
        int c1,c2,c3,c4,c5,c6, prom;
        System.out.print ("Escribe c1 ");
        c1=sc.nextInt();        
        System.out.print ("Escribe c2 ");
        c2=sc.nextInt();
        System.out.print ("Escribe c3 ");
        c3=sc.nextInt();
        System.out.print ("Escribe c4 ");
        c4=sc.nextInt();
        System.out.print ("Escribe c5 ");
        c5=sc.nextInt();
        System.out.print ("Escribe c6 ");      
        c6=sc.nextInt();            
        prom=(c1+c2+c3+c4+c5+c6)/6;  
        
         if (prom>=70)
          System.out.println("Aprobado ");
         if (prom<70)
          System.out.println("Reprobado ");
    }
}
