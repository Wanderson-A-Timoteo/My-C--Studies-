using System;

class Aula17{

  static void Main() {
    //int n1, n2, n3, n4, n5;
    int[] n = new int[5];
    int[] num=new int[3]{66, 77, 99};
    int[] num2={66, 77, 99, 66, 88};

    string[] veiculos = new string[3];
    veiculos[0]="Carro";
    veiculos[1]="Avião";
    veiculos[2]="Navio";



    n[0]=111;
    n[1]=222;
    n[2]=333;
    n[3]=444;
    n[4]=555;

    Console.WriteLine(n[4]);
    Console.WriteLine(num[2]);
    Console.WriteLine(num2[1]);

    Console.WriteLine(veiculos[0]);
    Console.WriteLine(veiculos[1]);
    Console.WriteLine(veiculos[2]);

  }
}