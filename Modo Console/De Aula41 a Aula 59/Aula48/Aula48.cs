using System;
// Recursividade - Uma função chamando ela mesma.
class Calc{
    public int soma(params int[]n){
        int somador = 0;
        for(int i = 0;i < n.Length; i++){
            somador += n[i];
        }
        return somador;
    }
    public double soma(params double[]n){
        double somador1 = 0;
        for(int i = 0;i < n.Length; i++){
            somador1 += n[i];
        }
        return somador1;
    }
    // Fatorial é um exemplo clássico de recursividade.
// Fatorial de 5! = 5*4*3*2*1, de 7 é 7! = 7*6*5*4*3*2*1 e assim por diante
// Criando a função fatorial.
    public int fat(int n){ // Como vimos p fatorial não pode passar de 1.
        int res;
        if(n <= 1){ // Aqui temos o controle de que o fatorial não vai ser menor que 1.
            res = 1;
        } else {
            res = n * fat(n-1); // Aqui temos o controle de que a função vai diminuir de 1 em 1 e que multiplicar pelo próximo número menor que ele.
        }
        return res;
    } // Aqui temos uma função que chama ela mesma. No caso no else. Com o controle de parada sendo no caso no if, ou seja, quando n for igual a 1 (pra que não multiplique o número por 0).
    class Aula48{
        static void Main(){
            Calc calc=new Calc();

            var res = calc.fat(7);

            Console.WriteLine(res);
        }
    }
}