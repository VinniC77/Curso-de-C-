using System;
class Aula08 {
    static void Main(){
        int v1, v2, soma;
        string nome;

        // Console.Write("Digite seu nome: ");
        // nome = Console.ReadLine(); // a função Read ou ReadLine (lê e quebra linha) serve para ler o que foi digitado pelo teclado, e nesse caso armazenar na variável nome.
        // Console.WriteLine("Nome digitado: {0}", nome);

        // CALCULADORA
        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine()); // Tudo que é digitado no teclado vem em STRING, portanto, precisamos informar quando queremos que o programa interprete quando é de outro tipo. No caso inteiro. A função int.Parse transforma o que vier em inteiro.
        Console.Write("Diite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;
        Console.Write("A soma de {0} e {1} é igual a {2}", v1, v2, soma);
    }
}