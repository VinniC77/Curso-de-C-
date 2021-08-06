using System;
using System.Collections.Generic;
// Coleção LinkedList - Lista duplamente encadeada. Onde cada elemento é um nó da lista que tem um link para o elemento posterior e anterior. (por isso é uma lista duplamente encadeada). Temos métodos para gerenciar (adicionar e remover) os elementos dessa lista. Toda LinkedList também é uma classe.
class Aula56{
    static void Main(){
        LinkedList<string> transporte = new LinkedList<string>();// Criação da LinkedList de tipo transporte.
        // Adicionando elementos à nossa lista.
        transporte.AddFirst("Carro"); // Adiciona elementos no início da lista.
        transporte.AddFirst("Avião");
        transporte.AddFirst("Navio");
        transporte.AddFirst("Moto"); // Dessa forma a Moto vai ficar no início, pois, foi a último elemento a ser inserido "first".

        // transporte.AddLast("Bicicleta"); // Adiciona os elementos no final da lista.

        // LinkedListNode<string> no; // Nó da lista
        // no = transporte.FindLast("Navio"); // Procura pelo último elemento apontado no parâmetro.
        // transporte.AddAfter(no, "Patinete"); // Adicona APÓS de um determinado elemento. Mas a forma de implementação é diferente. Precisamos informar o nó (LinkedListNode) e o valor que virá DEPOIS deste elemento. Ou seja, após o item Navio, vamos adicionar o elemento Patinete.

        // transporte.AddBefore(no, "Patins"); // Adiciona ANTES de um determindado elemento. Ou seja, vamos adicionar o elemento Patins antes do elemento Navio.
        // Percorrendo a lista e imprimindo-os.

        // transporte.Clear(); // Método Clear apaga toda a lista.

        // Método Find(); para verificar se eu tenho esse elemento na lista.
        if(transporte.Find("Carro") == null){
            Console.WriteLine("Elemento NÃO encontrado");
        } else {
            Console.WriteLine("Elemento Encontrado!");
        }

        // transporte.Remove("Navio"); // Remove o elemento especificado no parâmetro.
        transporte.RemoveFirst(); // Remove o PRIMEIRO elemento da lista
        transporte.RemoveLast(); // Remove o ÚLTIMO elemento da lista

        foreach(string transp in transporte){
            Console.WriteLine("Transporte: {0}", transp);
        }

    }
}