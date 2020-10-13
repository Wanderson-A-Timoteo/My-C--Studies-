using System;

class Aula14{

  static void Main() {
    
    int n1, n2, n3, n4, res, soma;
    soma=res=n1=n2=n3=n4=0;

    string resultado;

    Console.Write("Digite a nota 1: ");
    n1=int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 2: ");
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 3: ");
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    soma = n1 + n2 + n3 + n4;
    res = soma/4;


    if(res >= 60){
      if(res >= 90){
        if(res >=99){
          resultado="Aprovado com super louvor!";
        }else{
          resultado="Aprovado com louvor!";
        }
      } else{
        resultado="Aprovado!";
      }
    } else {
      if(res >= 40){
        resultado="Recuperação";
      } else {
        resultado="Reprovado";
      }
    }
    Console.WriteLine("\n Nota média: {0} \n Resultado: {1}", res, resultado);
  }

}