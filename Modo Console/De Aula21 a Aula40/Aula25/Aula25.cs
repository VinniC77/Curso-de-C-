using System;
class Aula25{
    static void Main(){
        // Métodos - Passagem por valor e passagem por referência.
        int num = 10;
        int num1 = 20;
        dobrar(num);
        Console.WriteLine(num); // neste caso a resposta é 10. Porque o método é passado por valor então ele vai pra uma posição na memória diferente e não afeta o valor da variavel num, mesmo colocando esse valor no parametro da função dobrar().
        dobrar1(ref num); // Quando passamos o valor por referencia, não cria uma nova posição na memória. Utiliza o valor colocado no parametro para a função. Lembrar sempre de usar o ref nesses casos.
        Console.WriteLine(num1);
    }
    static void dobrar(int valor){
        valor *= 2;
    }

    static void dobrar1(ref int valor){ 
    // Quando passamos o valor por referencia, não cria uma nova posição na memória.
        valor *= 2;
    }
}