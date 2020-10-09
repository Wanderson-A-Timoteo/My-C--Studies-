using System;
 class Aula09{

   static void Main() {

     int num = 10;
     int num2 = 10;

     num = num << 1; // Bitwise a esqueda dobra o valor
     num2 = num2 >> 1; // Bitwise a direita diminui metade do valor


     Console.WriteLine("\n Bitwise a esqueda, valor dobrado: {0} \n Bitwise a direita, valor metade: {1}", num, num2);

   }
 }