using System;
// Métodos virtuais - São métodos que tem o mesmo nome em classes diferentes. E vão executar uma ação diferente. Também precisamos especificar na classe base que este método é virtual e que poderá ser executado em uma classe derivada.
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base.");
    }
    virtual public void info(){ // Temos que colocar virtual para dizer ao programa que ele poderá ser usado mais a frente e ser sobrescrito.
        Console.WriteLine("Base");
    }
}
class Derivada1 : Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1.");
    }
    override public void info(){ // Se tentarmos mandar assim não vai, pois, na classe base já há um método info(), portanto, precisamos definí-lo como override. Assim, sabemos que esse método existe na classe base e está sendo sobrescrito na classe derivada.
        Console.WriteLine("Derivada 1");
        // Neste caso ao chamar o método, vai imprimir Derivada1, pois, o método info() foi sobrescrito através do override.
    }
}
class Derivada2 : Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2.");
    }
    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}
class Aula38{
    static void Main(){
        // E se quisermos que hora chama a derivada 1 e hora chame a derivada 2.
        // Derivada1 derivada1=new Derivada1();
        // Derivada2 derivada2=new Derivada2();
        // derivada1.info();
        // derivada2.info();
        // Mas existeuma possibilidade de criar um objeto da base e associar derivada 1 e derivada 2 a este objeto. Assim eu consigo ter controle aos seus prórpios métodos.
        Base Ref; // Ref cria um elemento de referencia que pode receber as classes derivadas dessa base.
        Derivada1 derivada1=new Derivada1();
        Derivada2 derivada2=new Derivada2();
        Ref=derivada2;
        Ref.info(); // Aqui ele chama o método info() de derivada 1 que está sobrescrevendo o método info() da classe base.
    }
}