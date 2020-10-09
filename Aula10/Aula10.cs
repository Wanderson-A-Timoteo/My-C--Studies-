using System;

class Aula10{

enum DiasSemana{
      Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
    };
  static void Main() {
    
    DiasSemana ds = DiasSemana.Domingo; // Imprime o valor definido diretamente

    Console.WriteLine(ds);

    DiasSemana Dss = (DiasSemana) 3; // Imprime o valor definido pelo indice, neste caso 3 indice 3.

    Console.WriteLine(Dss);

    int indice = (int) DiasSemana.Sexta; // Neste caso, o (int) converte a operação e imprime o valor do 
    // indice da posição Sexta no array, neste caso o indice  de Sexta é 5.

    Console.WriteLine(indice);

  }
}