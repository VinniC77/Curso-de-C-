using System;
// Método Construtor - Vai inicializar o objeto quando instanciado da classe. Quando instanciar um objeto desta classe o Método Construtor é chamado. O principal objetivo é inicializar as propriedades instauradas na classe. 
public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){ // O método construtor sempre tem o mesmo nome da classe. 
        energia = 100; // É mais indicado introduzir os valores nos métodos, não nas classes.
        vivo = true;
        nome = n; // Agora o método tem um argumento a ser passado quando for chamado.
    }
    ~Jogador(){ // Para o método destrutor basta colocar o mesmo nome da classe precedido por um ~.
            // Método Destrutor - Vai ser executado quando a classe for destruída.
            Console.WriteLine("Jogador {0} foi Destruído", nome);
    }
}
class Aula29{
    static void Main(){
        // Jogador j1=new Jogador("Vini");
        // Jogador j2=new Jogador("Orival");
        // j1.energia = 50;
        // Console.WriteLine("Nome do jogador j1: {0}", j1.nome);
        // Console.WriteLine("Nome do jogador j2: {0}", j2.nome);
        
        // Passando o nome do jogador através do que for digitado:
        string nome1;
        Console.WriteLine("Digite o nome do jogador 3: ");
        nome1 = Console.ReadLine();
        Jogador j3=new Jogador(nome1);
        Console.WriteLine("Nome do jogador j3: {0}", nome1);
    }
}