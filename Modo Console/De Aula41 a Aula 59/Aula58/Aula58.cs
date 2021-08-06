using System;
using System.Collections.Generic;
// Coleção List - Ela vai ser usada toda vez que quisermos substituir um array tradicional. Entendemos a list como se fosse um array dinâmico.
class Aula58{
    static void Main(){
        List<string> carros=new List<string>();
        
        carros.Add("Golf");
        carros.Add("Audi");
        carros.Add("Focus");
        carros.Add("Fusca");
        carros.Add("Audi");
    
        string[] carros2=new string[10];
        // carros2.AddRange(carros);

        // carros.Clear();
        
        carros.Contains("Audi");
        carros.CopyTo(carros2, 2);

        carros.Insert(1, "Chevette"); // Insere na posição do primeiro parâmetro o valor informado no segundo parâmetro.

        Console.WriteLine("O último Audi encontrado está na posição: " + carros.LastIndexOf("Audi"));// Mostra a posição do último elemento encontrado.

        // carros.Remove("Fusca"); // Remove o elemento indicado nos parâmetros.

        // carros.RemoveAt(0);// Remove o elemento baseado na posição do índice indicada nos parâmetros.

        // carros.Reverse();// Inverte a ordem da lista

        // carros.Sort();// Ordena em ordem alfabética os elementos da lista.

        Console.WriteLine("Quantidade de elementos da lista: " + carros.Count); // Trás a quantidade de elementos na lista.

        Console.WriteLine("Capacidade de armazenamento da lista: " + carros.Capacity);// Retorna a capacidade de armazenamento de elementos que nossa lista tem.


        Console.WriteLine("Carro Focus está na posicão: " + carros.IndexOf("Focus"));

        foreach(string carro in carros){
            Console.WriteLine("Carro: {0}", carro);
        }
    }
}