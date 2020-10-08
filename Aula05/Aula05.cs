using System;

class Aula05 {

  static void Main() {

    int res = 10 + 5;

    int res2 = 10 + 5 * 2;

    int res3 = (10 + 5) * 2;

    bool res4 = 10 < 5; 

    bool res5 = 10 > 5;

    bool res6 = 10 == 5;

    bool res7 = 10 != 5;

    int num = 10;
    int num2 =10;

    num++; // exemplo de incremento: num++; | num = num + 1; | num+=1;  

    num2*=2; // exemplo de incremento pode-se usar  + = * /.

    // & = AND / E
    // | = OR / OU

    bool res8 = (5 > 3) & (10 > 5);

    bool res9 = (5 > 3) | (10 > 5);


    bool res10 = (5 < 3) & (10 > 5);

    bool res11 = (5 < 3) | (10 > 5);



    Console.WriteLine(res);
    Console.WriteLine(res2);
    Console.WriteLine(res3);
    Console.WriteLine(res4);
    Console.WriteLine(res5);
    Console.WriteLine(res6);
    Console.WriteLine(res7);
    Console.WriteLine(num);
    Console.WriteLine(num2);
    Console.WriteLine(res8);
    Console.WriteLine(res9);
    Console.WriteLine(res10);
    Console.WriteLine(res11);



  }
}