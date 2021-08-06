using System;
class Aula20{
    static void Main(){
    // While - Usamos quando não temos certeza de quantas vezes iremos repetir determinado comando.

        int [] num=new int[10];
        int i = num.Length-1; // A criação da var deve ser fora do bloco, senão dá loop infinito.
        while(i > 0){ // Enquanto a expressão ser true ele vai seguir executando
            num[i] = 0;
            Console.WriteLine(num[i]);
            i--;
        }   Console.WriteLine("Fim do Loop");
    }
}
