using System;
// Classes Estáticas - static - Classes static não permitem a instanciação de objetos e não permite o uso de construtores.
// Todas as classes static tem que ter membros e propriedades static.
static public class Jogador{
    static public int energia; //Para que funcione é preciso identificar todos os membros como static.
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info(){
        Console.WriteLine("Nome do jogador....: {0}", nome);
        Console.WriteLine("Energia do jogador.: {0}", energia);
        Console.WriteLine("Estado do jogador..: {0}\n", vivo);
    }
}

// Exercício. Digamos que estou criando um jogo. Vamos criar os inimigos agora
class Inimigo{
    static public bool alerta; // Criando as propriedades da classe Inimigo.
    // Agora com o alerta sendo static. Todos os inimigos com essa propriedade vão herdar o que foi definido em alerta
    public string nome;
    public Inimigo(string n){ // Construtor
        alerta = false;
        nome = n;
    }
    public void info(){ // Criação do método info para imprimir as informações de Inimigo.
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("-------------------------");
    }
}

class Aula31{
    static void Main(){
        // No programa vamos instanciar 3 inimigos.
        Inimigo i1=new Inimigo("Doido");
        Inimigo i2=new Inimigo("Maluco");
        Inimigo i3=new Inimigo("Pirado");

        Inimigo.alerta = true; // Definindo o alerta como true. Para definí-lo, devemos acessá-lo a partir da classe Inimigo. Agora todos os inimigos herdam o alerta como true, pois é uma propriedade static. O static é guardado em somente 1 espaço na memória, então uma vez definido, todas as propriedades que contém alerta herdarão o que foi passado.

        i1.info();
        i2.info();
        i3.info();
    // Dessa maneira todos os alertas foram false, porque já foram definidos.
    // Agora quando eu emitir um alerta. quero que todos os inimigos entrem em estado de alerta.
    // Para isso usamos o static
    }
}

// O que temos que ter em mente em relação a static. Quando eu definir uma classe como static, eu não posso ter construtor, pois, não podemos declarar um objeto da classe static. Portanto, todos os membros da classe precisam ser static.
// Quando criamos propriedades static significa que todos os objetos da classe irão apontar pra essa propriedade. Cada objeto NÃO terá sua propriedade "alerta" nesse caso. Todos vão apontar pra mesma propriedade alerta. Por isso que quando definimos ela, ela valerá pra todas as classes. 