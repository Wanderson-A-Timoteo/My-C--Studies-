using System;

class Aula16{

  static void Main() {
    
    int tempo=0;
    char escolha;

    inicio: 

    Console.Clear();
    
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

    Console.Write("\n Calcular com outro transporte? [s/n]: ");

    escolha=char.Parse(Console.ReadLine());
    if(escolha=='s' || escolha=='S'){
      goto inicio;
    } else{
      Console.Clear();
      Console.WriteLine("Fim do programa");
    }
  }
}