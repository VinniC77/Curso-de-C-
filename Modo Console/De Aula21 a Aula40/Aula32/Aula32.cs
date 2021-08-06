using System;

class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2){ // Método construtor. Neste caso os parametro tem os mesmos nomes das variáveis da classe. Se fizermos:
        // v1 = v1;
        // v2 = v2;
    // O programa não vai compilar e dará um alerta de que estamos tentando atribuir um valor à mesma variável.
    // Para especificar que estamos nos referindo as var da classe e não do método construtor, usamos o .this
        this.v1 = v1;
        this.v2 = v2; // O this faz referencia ao objeto. Estamos falando que esse v1 pertence ao objeto v1 da classe e não ao v1 do parâmetro.

    }
    
    public int Somar(){ // Método simples da classe Calculos.
        return v1 + v2;
    }
}
class Aula32{
    static void Main(){
        // Operador THIS
        Calculos c=new Calculos(10, 2);

        Console.WriteLine(c.Somar()); // Do obejto c eu chamo o método Somar().
        // O this sempre faz referencia ao objeto pai, no caso Calculos.
    }
}