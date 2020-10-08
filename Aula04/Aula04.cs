using System;

class Aula04 {

  static int num = 10; // Variavel GLOBAL
  static void Main(){
    int num2 = 0; // Variavel local do metodo Main()
  
    Console.WriteLine(num); // Vai imprimir apenas a variavel local do metodo teste().
  }
}