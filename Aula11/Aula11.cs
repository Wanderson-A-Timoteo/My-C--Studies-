using System;

class Aula11 {

  static void Main() {

    int n1=10;
    float n2=n1; // Conversão implicita, segura

    //float n3 = 10.5f; // Não é possível converter implicitamente o tipo float em int, Existe uma conversão explícita. Precisa de cast
    //int n4 = n3;

    Console.WriteLine(n2);


    float n3 = 10.5f;
    int n4 = (int) n3; // Esta é uma operação type cast, uma conversão explicita

    Console.WriteLine(n4);


    //int vInt = 10;
    //short vShort = vInt; // Não é possível converter implicitamente o tipo float em int, Existe uma conversão explícita. Precisa de cast

    int vInt = 10;
    short vShort = (short)vInt; // Esta é uma operação type cast, uma conversão explicita

    Console.WriteLine(vShort);
  }
}