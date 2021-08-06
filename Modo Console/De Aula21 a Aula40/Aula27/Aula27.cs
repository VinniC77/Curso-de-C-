using System;
class Aula27{
    static void Main(){
// Argumento params - Permite a entrada de 0 ou mais parametros para dentro de uma função sem ter que especificar os valores na construção da função. Sem ter que indicar no corpo da função.
        soma(6, 7, 4, 33, 54, 12);
    }
    static void soma(params int[]n){ // Agora são 3 situações que podem ocorrer ao executar o a função. Receber nenhum valor, somente 1 valor ou mais de 1 valor. Vamos tratar todas elas:
    int res = 0;
    if(n.Length < 1) { // Neste caso significa que na hora em que a função foi chamada não foram colocados valores nos parametros.
        Console.WriteLine("Não existem valores a serem somados");
    } else if(n.Length < 2){ // Neste caso só foi colcodo 1 valor na função soma.
        Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
    } else { // Só vai chegar aqui se o número de parametros for maior do que 1. Ou seja, agora há possibilidade de executar a função normalmente.
        for(int i = 0; i < n.Length; i++){ // Precisamos percorrer todas as posições do array para somá-las.
            res += n[i]; // Vai somar ao valor de res (que é zero) o valor da posição que está percorrendo.
        }
        Console.WriteLine("A soma dos valores é: {0}", res);
    }
    }
}