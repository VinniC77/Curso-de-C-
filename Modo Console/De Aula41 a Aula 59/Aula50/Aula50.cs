using System;
// Delegates - É um objeto que pode fazer referencia a um método ou quantos métodos eu quiser dentro da minha classe. Podemos ter uma classe com vários métodos static e podemos criar um delegate que vai fazer referência a todos esses métodos dessa classe.
delegate int Operacoes(int n1, int n2);
class Mat{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }
    public static int mult(int n1, int n2){
        return n1 * n2;
    }
}
class Aula50{
    static void Main(){
        // Como fazemos o uso do delegate apontando para as operações de mult e soma.
        int res;
        Operacoes op1=new Operacoes(Mat.soma); // A criação do objeto é feita somente 1 vez. 
        res = op1(10,5); // Depois é só passar as referencias dos métodos que eu quero associar ao novo objeto
        Console.WriteLine("Soma.........: {0}", res);
        op1=new Operacoes(Mat.mult);
        res = op1(10, 5);
        Console.WriteLine("Multiplicação: {0}", res);
    }
}