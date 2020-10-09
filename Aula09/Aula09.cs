using System;
 class Aula09{

   static void Main() {

     int num = 10;
     int num2 = 10;
     int num3 = 10;
     int num4 = 10;



     num = num << 1; // Bitwise a esqueda dobra o valor
     num2 = num2 >> 1; // Bitwise a direita diminui metade do valor

     num3 = num3 << 2; // Bitwise a esqueda dobra o valor
     num4 = num4 >> 2; // Bitwise a direita diminui metade do valor


     Console.WriteLine
     ("\n Bitwise a esqueda, valor dobrado: {0} \n Bitwise a direita, valor metade: {1} \n Bitwise a esqueda por 2, valor dobrado: {2} \n Bitwise a direita por 2, valor metade: {3}", num, num2, num3, num4);
     
   }
 }