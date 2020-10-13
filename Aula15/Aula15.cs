using System;

class Aula15{

  static void Main(){

    int tempo=0;
    char escolha;

    Console.WriteLine("Viagem de Cuiabá/MT para São Paulo/SP");
    Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus: ");
    
    escolha=char.Parse(Console.ReadLine());

    switch(escolha){
      case 'a':
      case 'A':
        tempo=60;
        break;

      case 'c':
      case 'C':
        tempo=480;
        break;

      case 'o':
      case 'O':
        tempo=650;
        break;

      default:
        tempo=-1;
        break;
    }

    if(tempo < 0){
      Console.WriteLine("Transporte indisponível");
    } else {
      Console.WriteLine("O tempo para o transporte escolhido é: {0} minutos", tempo);
    }

  }
}