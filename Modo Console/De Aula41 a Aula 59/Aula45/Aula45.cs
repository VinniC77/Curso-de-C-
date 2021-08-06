using System;
// Array de estruturas - Vinculando o trabalho de arrays com structuring
struct Carro{
    public string modelo;
    public string cor;
    public void info(){
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
        Console.WriteLine("------------------------");
    }
}
class Aula44{
    static void Main(){
    // Se precisarmos de uma estrutura para montar 4 carros.
        Carro[] carros=new Carro[4]; // Estamos criando um array do tipo Carro.
    // Atribuindo valores aos índices do array carros.
        carros[0].modelo = "Porsche"; // Como o construtor carro exige 2 parametros devemos informar depois do ponto.
        carros[0].cor = "Preto";

        carros[1].modelo = "Ferrari";
        carros[1].cor = "Amarelo";

        carros[2].modelo = "Bugatti";
        carros[2].cor = "Cinza";

        carros[3].modelo = "Lamborghini";
        carros[3].cor = "Preta";

        carros[0].info();
        carros[1].info();
        carros[2].info();
        carros[3].info();

    // Ou para facilitar, podemos colocar dentro de um loop.
        for(int i = 0; i < carros.Length; i++){
            carros[i].info();
        }
    }
}