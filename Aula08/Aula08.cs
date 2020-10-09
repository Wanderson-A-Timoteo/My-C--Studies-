using System;

class Aula08 {

  static void Main() {
    int v1, v2, soma;
    string nome;


    Console.Write("Digite seu nome: ");
    nome=Console.ReadLine(); // Lê o que vem do teclado
    Console.WriteLine("Nome digitado: {0}", nome);

// Todos os dados inseridos pelo teclado são uma string, por isso ao trabalhar com numeros é preciso 
// converter para inteiro, existem 02 metodos de conversão, abaixo:
    Console.Write("Digite o primeiro valor: ");
    v1=int.Parse(Console.ReadLine()); // 1º Metodo: int.Parse converte numeros de string para inteiro
    Console.Write("Digite o segundo valor: ");
    v2=Convert.ToInt32(Console.ReadLine());// 2º Metodo: Convert.ToInt32 converte numeros de string para inteiro
    soma=v1+v2;
    Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);

  }
}