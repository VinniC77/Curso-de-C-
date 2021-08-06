using System;
using System.Collections.Generic;
// Coleção List - Ela vai ser usada toda vez que quisermos substituir um array tradicional. Entendemos a list como se fosse um array dinâmico.
class Aula57{
    static void Main(){
        List<string> carros=new List<string>(); // Lista carros criada.
        
        carros.Add("Golf");// Adicionando elementos.
        carros.Add("Audi");
        carros.Add("Focus");
        carros.Add("Fusca");
    
        string[] carros2=new string[10]; // Lista carros2 criada.
    // Se quisermos adicionar os itens de uma lista em outra lista.
        // carros2.AddRange(carros); // Agora a lista carros2 recebeu os mesmos elementos da lista carros.

        // carros.Clear(); // Limpa todos os elementos da lista
        
        carros.Contains("Audi"); // Verifica se a lsita contém o item especificado no parâmetro. Retorna um boolean.
        carros.CopyTo(carros2, 2);// A partir de qual elemento (passado através da posição, no caso 2) eu quero copiar os elementos de uma lista para outra.

        Console.WriteLine("Carro Focus está na posicão: " + carros.IndexOf("Focus"));// Retorna o índice da primeira ocorrência que ele encontrar.

        foreach(string carro in carros){
            Console.WriteLine("Carro: {0}", carro);
        }
    }
}