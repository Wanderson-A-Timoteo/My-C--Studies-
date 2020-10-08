using System;

class Aula06{

  static void Main() {

    int n1, n2, n3;
    n1=10;
    n2=20;
    n3=30;
    double valorCompra = 5.50;
    double lucro = 0.1;
    string produto="Pastel";
    double valorVenda;

    valorVenda = valorCompra+(valorCompra*lucro);

    Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3 );
    Console.WriteLine("\n n1={0}\n n2={1}\n n3={2}", n1, n2, n3 );
    Console.WriteLine("\n n1=\t{0}\n n2=\t{1}\n n3=\t{2}", n1, n2, n3 );

    Console.WriteLine("Produto..............:{0,15}", produto);
    Console.WriteLine("Valor de Compra......:{0,15:c}", valorCompra); // c sig formato monetario, assim é colocado o $
    Console.WriteLine("Lucro................:{0,15:p}", lucro); // p sig porcentagem
    Console.WriteLine("Valor de Venda.......:{0,15:c}", valorVenda);

  }
}