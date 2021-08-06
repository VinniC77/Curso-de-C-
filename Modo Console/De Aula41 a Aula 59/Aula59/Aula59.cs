using System;
using System.Collections.Generic;
// Coleção Queue (Fila) - Onde o primeiro elemento a entrar é o primeiro elemento a sair da fila. Trabalha sempre com o primeiro elemento. Manipula sempre o elemento que está no ínicio da fila.
// Não podemos indexar as posições do tipo Queue(como se fosse com arrays Exemplo[i]).
class Aula59{
    static void Main(){
        // string[] vs={"Carro", "Aviao", "Moto", "Navio"};
        // Queue<string> veiculos=new Queue<string>(vs); // Podemos iniciar a fila já com elementos pré-estabelecidos, assim como nas listas anteriores. Opção de inicialização.

        Queue<string> veiculos=new Queue<string>();

        veiculos.Enqueue("Carro"); // Adicionando elementos no final da queue (fila).
        veiculos.Enqueue("Aviao");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");

        // Retorna um boolean se o elemento especificado está na fila ou não.
        string v = "Patinete";
        if(veiculos.Contains(v)){
            Console.WriteLine("Veículo " + v + " encontrado");
        } else {
            Console.WriteLine("Veículo " + v + " não está na fila");
        }
        // veiculos.Clear(); // Limpa a fila.
        Console.WriteLine("Primeiro veículo " + veiculos.Dequeue());// Dequeue retorna o primeiro elemento e elimina/remove ele da fila.

        Console.WriteLine("Primeiro veículo: " + veiculos.Peek());// Retorna o primeiro elemento, mas não remove da fila.

        // Retornar todos os elementos da fila.
        foreach(string vei in veiculos){
            Console.WriteLine("Veículo: " + vei);
        }

        Console.WriteLine("Quantidade de elementos da fila: " + veiculos.Count);
    }
}