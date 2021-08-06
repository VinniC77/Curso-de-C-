using System;
class Aula22{
    static void Main(){
        // Loop forEach - Serve para iterar e LER os elementos de uma colação, sem alterá-los.
        int[] num=new int[3]{11, 22, 33};

        // for normal. Onde temos o controle de posições ao declararmos i = 0;
        // for(int i=0; i < num.Length; i++){
        //     Console.WriteLine(num[i]);
        // }
        // Quando for preciso a leitura e iteração dos elementos é recomendada a utlização do forEach.
        foreach(int n in num){ // é preciso criar uma variável de mesmo tipo do array/matriz. No caso n
            Console.WriteLine(n);
        }

    }
}