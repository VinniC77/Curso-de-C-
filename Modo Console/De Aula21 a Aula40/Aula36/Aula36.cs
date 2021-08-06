using System;
// Membros Protected - Semelhante ao private, mas o private somente se acessa pela classe Base e o protected eu posso acessar pela classe Base e também pelas classes Derivadas.

class Veiculo{ // Classe Base
    public int velAtual;
    private int velMax; // O private restringe o acesso ao membro somente à classe. Ou seja, só posso acessá-los com métodos da própria classe.
    protected bool ligado; // O protected permite o acesso aos membros pelas classes derivadas. Mas somente pelas classes, se eu tentar acessar esse membro fora da classe, ou seja, pelo objeto, eu não tenho acesso.
    public Veiculo(int velMax){ // Método Construtor para inicializar as var.
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}
class Carro: Veiculo{ // Classe Carro que herda a classe Veiculo, ou seja, derivada.
    public string nome;
    public Carro(string nome, int vm):base(vm){ // Construtor da classe Carro. Temos que ter em mente que a classe Base Veiculo necessita de um argumento, no caso a velMax, por isso precisamos especificar a base
        this.nome = nome;
    // Não podemos acessar a velMax, pois ela é private, mas podemos acessar a ligado que é protected.
        ligado = true;
    }
}
class Aula36{
    static void Main(){
        // Instanciando objetos da classe Carro.
        Carro c1=new Carro("Fusca", 180); // Precisamos passar o nome e a velMax.
        Console.WriteLine("Nome......: {0}", c1.nome); // Conseguimos acessar o nome, pois, ele é public.
        Console.WriteLine("Vel.Máxima: {0}", c1.getVelMax()); // Precisamos invocar o método da velMax, pois, a var velMax é private.
        Console.WriteLine("Ligado....: {0}", c1.getLigado()); // Precisamos invocar o método do ligado, pois, a var ligado é protected.
    }
}