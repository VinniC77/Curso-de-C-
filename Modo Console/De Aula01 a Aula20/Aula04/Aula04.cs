using System;
class Aula04{

    int num1 = 10; // Essa var está no escopo global da classe, pois, não está dentro de nenhum método.
    static void Main(){
        int num = 0; // variavel local. Só pode ser acessada dentro do método Main
    }

    void teste(){
        Console.WriteLine(num); // Dá erro ao tentar mostrar no console. Só é acessada dentro do seu escopo.
    }
}