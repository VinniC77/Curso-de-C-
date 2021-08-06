using System;
class Aula21{
    static void Main(){
        // DO While - Com o Do While eu garanto que pelo menos uma vez os comandos serão executados.
        // no While antes testa a condição depois executa.
        // int num = 5;
        // while(num > 5) { // Nesse caso não será impresso nenhuma vez, pois a condição é falsa de cara.
        //     Console.WriteLine("Vini é o foda!");
        // }
        // no Do While o teste é feito no final
        // int n = 5;
        // do { // Por esse comando ele executa
        //     Console.WriteLine("Vini é foda mesmo!");
        // } while (n > 5); // e só depois ele testa. O que garante pelo menos uma execução.

        // Sistema de Senha
        string senha = "123";
        string senhaUser;
        int tentativas = 0;

        do {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhaUser = Console.ReadLine();
            tentativas++;
        } while(senha != senhaUser);
            Console.Clear();
            Console.WriteLine("Senha Correta, tentativas: {0}", tentativas);
    }
}