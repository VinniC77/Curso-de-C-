using System;
// Sobrecarga de Construtores - Quando queremos adicionar mais de um construtor para o método.
public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    // Podemos criar vários construtores para o mesmo método.
    public Jogador(){ // Definindo um construtor sem nenhum parâmetro. Ou seja, quando não passar nada nos parâmetros, ele irá assumir os campos já definidos.
        energia = 100;
        vivo = true;
        nome = "Romário";
    }
    public Jogador(string n){ // Quando eu passar o nome do jogador. O nome vai ser o que eu passar, a energia 100 e vivo true.
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e){ // Neste caso precisamos passar o nome e a energia.
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e, bool v){ // Todos os parâmetros são necessários.
        energia = e;
        vivo = v;
        nome = n;
    }
    public void info(){ // Esse método irá imprimir as informações.
        Console.WriteLine("Nome do jogador....: {0}", nome);
        Console.WriteLine("Energia do jogador.: {0}", energia);
        Console.WriteLine("Estado do jogador..: {0}\n", vivo);
    }
}

class Aula30{
    static void Main(){
        Jogador j1=new Jogador();
        Jogador j2=new Jogador("Vini");
        Jogador j3=new Jogador("Jeferson", 70);
        Jogador j4=new Jogador("Marcondes", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();

    }
}