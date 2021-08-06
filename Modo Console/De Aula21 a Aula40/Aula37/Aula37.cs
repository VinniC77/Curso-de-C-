using System;
// Herança - Ordem de execução dos construtores.
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base.");
    }
}
class Derivada1 : Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1.");
    }
}
class Derivada2 : Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2.");
    }
}
class Aula37{
    static void Main(){
        Derivada2 derivada21=new Derivada2();
        // A ordem de execução é sempre da Base para a derivada.
    }
}