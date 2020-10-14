using System;

class Aula19 {

  static void Main(){

    int num;
    int[] num2=new int[10];

    for(num = 0; num < 10; num++){

      Console.WriteLine("Wanderson: {0}", num);

    }
    for(int i=0; i < num2.Length; i++){ 
        num2[i]=i;

        Console.WriteLine("Valor de NUM2 na posição {0}: {1}", i, num2[i]);

    }
    
  }
}