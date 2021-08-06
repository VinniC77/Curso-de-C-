using System;
class Aula03{
    static void Main(){
        byte n1 = 10; // entre 0 e 255
        int num = 0; // numeros positivos e negativos
        char letra = 'a'; // armazena somente 1 caractere
        float valor = 5.2f;
        string nome = "Vini";
        var aux = nome; // var é usado para criar uma variável sem especificar o tipo
        int num1, num2, res; // para criar várias variáveis de uma só vez
        num1 = 10;
        num2 = 2;
        res = num1 + num2;

        Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a: " + res);
        Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a: " + (num1 + num2));
    }
}