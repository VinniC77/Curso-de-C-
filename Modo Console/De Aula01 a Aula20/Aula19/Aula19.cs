using System;
class Aula19{
    static void Main(){
        // for (int num = 0;num < 10; num++){
        //     Console.WriteLine("Valor de num: {0}", num);
        // 
        int [] num=new int[10]; // Utilizando o for com array
        for (int i = 0;i > 10; i++){
            num[i] = 0;
        }
        for (int i=0; i<num.Length; i++) {
            Console.WriteLine("Valor de num na posição {0}: {1}", i, num[i]);
        }
    }
}