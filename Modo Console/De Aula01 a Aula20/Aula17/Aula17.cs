using System;
class Aula17{
    static void Main(){
        Array
        int[] n=new int[5]; //Criação de Array de inteiro. n é o nome. 5 é a quantidade de elementos do array.
        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;
        Console.Write(n[3]);
        
        Declarando e atribuindo valores no array
        int[] num = new int[3]{55, 77, 99};
        Console.Write(num[2]);

        // Outra maneira de declarar e já atribuir valores no array:
        int[] numeros = {55, 66, 88};

        string[] veiculos = {"Mercedez", "Ferrari", "Porsche", "Camaro"};
        Console.WriteLine(veiculos[2]);
    }
}