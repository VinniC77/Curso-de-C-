using System;
class Aula24{
    static void Main(){
    // Métodos - São conjuntos de instruções e quando eu quiser executar essas instruções eu chamo o método.
    // static é o método / void é o tipo de dados que o método vai retornar. No caso void não retorna nada.
    // Main é simplesmente o nome do método, ou seja, pode ser qualquer coisa.
    // Entre os parênteses vão os parâmetros de entrada do método.
    // As chaves são os delimitadores do método. Tudo que estiver dentro delas será executado quando o método for chamado.
        // cfb(); // Método simples - Sem parâmetros.
        int v1, v2;
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        // soma(v1, v2); // Método executando os comandos que vem do teclado (usuario).
        Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, somatorio(v1,v2));
    }
    static void cfb(){
        Console.WriteLine("CFB Cursos");
    }
    // static void soma(int n1, int n2){ // Método com 2 argumentos
    //     int res = n1 + n2;
    //     Console.WriteLine("A soma de {0} e {1} é igual a {2}", n1, n2, res);
    // }
    static int somatorio(int n1, int n2){ // Método que retorna um valor. No caso um inteiro.
        int res = n1 + n2;
        return res;
    }
}