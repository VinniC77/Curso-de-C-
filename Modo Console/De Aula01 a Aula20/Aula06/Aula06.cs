using System;
class Aula06{
    static void Main(){
        // int n1, n2, n3;
        // n1 = 10;
        // n2 = 20;
        // n3 = 30;
        // Console.Write("n1= {0}, n2= {1}, n3= {2}", n1, n2, n3); // é possível acessar as variáveis pelo índice
        // Console.Write("\nn1= {0},\nn2= {1},\nn3= {2}\n", n1, n2, n3); // o \n é para quebrar linhas
        // Console.Write("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n", n1, n2, n3); // o \t serve para fazer tabulação

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);
        
        Console.WriteLine("Produto.....:{0,15}", produto); // o ZERO é o índice da declaração, que só tem 1.
        Console.WriteLine("Val.Compra..:{0,15:c}", valorCompra); // c(currency) dá a saída em valor monetário.
        Console.WriteLine("Lucro.......:{0,15:p}", lucro); // p transoforma a saída em porcentagem.
        Console.WriteLine("Val.Venda...:{0,15:c}", valorVenda); // O 15 é o espaçamento de tabulação que eu quero adicionar entre o texto e a var
    }
}