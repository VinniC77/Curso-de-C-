using System;
class Aula18{
    static void Main(){
        // Matrizes - São uma espécie de array com 'linhas e colunas'.
        int[,] n=new int[3,5]; 
        // // Na criação a diferença para array é a , entre os conchetes. Neste caso com 3 linhas e 5 colunas.
        // /*
        // 01 02 03 04 05
        // 06 07 08 09 10
        // 11 12 13 14 15
        // */

        n[0,0] = 01; n[0,1] = 02; n[0,2] = 03; n[0,3] = 04; n[0,4] = 05;

        n[1,0] = 06; n[1,1] = 07; n[1,2] = 08; n[1,3] = 09; n[1,4] = 10;

        n[2,0] = 11; n[2,1] = 12; n[2,2] = 13; n[2,3] = 14; n[2,4] = 15;

        Console.WriteLine(n[1,3]);
        Console.WriteLine(n[2,1]);

        int[,] num=new int[2,2]{{10,20},{30,40}}; // Criação de matrizes com atribuição de valores. 2 linhas e 2 colunas. Primeira Linha 10 e 20, Segunda linha 30, 40

        Console.WriteLine(num);
    }
}