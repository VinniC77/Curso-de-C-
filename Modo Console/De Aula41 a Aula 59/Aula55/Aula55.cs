using System;
// Coleção Dictionary - É uma coleção de dados, sendo o dado relacionado por uma dupla de chaves e valores.
using System.Collections.Generic; // Precisamos importar a biblioteca de coleções genéricas para ter acesso ao Dictionary
class Aula55{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary<int, string>();// Criando um dicionário
// Precisamos especificar um tipo para chave e um tipo para valor. No caso a chave é int e o valor é string. veiculos é o novo tipo criado e do new pra frente é para criar as bases desse novo tipo.
    // Adicionando elementos nesse Dictionary
        // Dictionary é uma classe e possue alguns métodos. Vamos utilizar o método Add
        veiculos.Add(10, "Carro"); // Chave 10 e valor Carro.
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");
    // Outros métodos de Dictionary.
        // veiculos.Clear(); // Limpa o Dictionary
    Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
    // Contém keys - Verifica se o dicionário criado tem a CHAVE que eu especificar na chamada do método. Retorna um true ou false
    Console.WriteLine(veiculos.ContainsKey(5));
    // Contém keys - Verifica se o dicionário criado tem o VALOR que eu especificar na chamada do método. Retorna um true ou false
    Console.WriteLine(veiculos.ContainsValue("nete"));
    // Remove - Apaga o item conforme a chave passada.
    veiculos.Remove(20);
    Console.WriteLine(veiculos.ContainsKey(20));
    // Se quisermos mudar a chave ou um valor
    veiculos[15] = "Bicicleta"; // Agora a chave 15 do dicionario veiculos receberá o valor Bicicleta.
    // Para imprimir todos os elementos da coleção veiculos.
    foreach(KeyValuePair<int, string> v in veiculos){ // Como a coleção tem int e string, precisamos transformar o parametro em KeyValuePair
        Console.WriteLine(v); // Ou podemos imprimir só os valores através do v.Value ou as chaves através do v.Key
    // Outra forma de imprimir os elementos da coleção veiculos.
    //     Dictionary<int, string>.ValueCollection valores = veiculos.Values; //Aqui estamos criando e colocando na variável valores, que é do tipo ValueColeciton os valores da coleção veiculos.
    // foreach(string vei in valores){
    //     Console.WriteLine(vei);
    // }
      }
    }
}