using System;

class Veiculo{
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas){ // Criando um construtor para a variável rodas na classe Base.
        this.rodas = rodas;
    }
    public void ligar(){
        ligado=true;
    }

    public void desligar(){
        ligado=false;
    }
    
    public string getLigado(){
        // Operador Ternário
        return (ligado? "Sim" : "Não");
        // if(ligado){
        //     return "Sim";
        // } else {
        //     return "Não";
        // }
    }
    public int getRodas(){ // Precisamos de um método para inicializar rodas na classe Base.
        return rodas;
    }
    public void setRodas(int rodas){ // Se precisarmos mudar o número de rodas, precisamos criar um setRodas:
        if(rodas < 0){ // Não podemos aceitar um veiculo com menos de 0 rodas.
            this.rodas = 0;
        } else if(rodas > 40){ // Não podemos aceitar um vaiculo com mais de 40 rodas.
            this.rodas = 40;
        } else {
            this.rodas = rodas;
        }
    }
}

class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){ // Para ter acesso a rodas, precisamos iniciar o construtor da classe base aqui na classe derivada. No caso base que precisa de 1 argumento para rodas.
        desligar();
        // rodas=4; // Não conseguimos mais acessar o rodas daqui, pois, agora ele é private
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

// Também podemos usar uma cadeia de herança.
class CarroCombate:Carro{ // Classe CarroCombate que herda Carro. Agora tudo que tem como public em Veiculo eu posso acessar tanto em Carro como em CarroCombate. Ou seja, CarroCombate herdará tudo de Carro e de Veiculo. É como se fosse filho de Carro e neto de Veiculo.
    public int municao;
    public CarroCombate():base("Carro de Combate", "Verde"){ // Método Construtor
        municao = 100;
    // Mas a classe Carro (que é pai da CarroCombate) tem um Construtor que precisa de 2 parâmetros (nome e cor). Então precisamos infomar a base também aqui.
    // Agora se quisermos definir o número de rodas no CarroCombate, nós precisamos chamar o setRodas.
        setRodas(6);
    }
        
}

class Aula35{
    static void Main(){
        Carro c1=new Carro("Rapidão", "Vermelho");
    // Assim nós temos uma cadeia de herança, onde CarroCombate herda Carro que herda Veiculo
        CarroCombate cc1=new CarroCombate();

        c1.ligar();

        Console.WriteLine("Cor.......: {0}", c1.cor);
        Console.WriteLine("Nome......: {0}", c1.nome);
        Console.WriteLine("Rodas.....: {0}", c1.getRodas()); // Da mesma forma, para obter rodas, precisamos iniclizar o método rodas, pois a variável não é mais public e sim private.
        Console.WriteLine("Vel.Máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado....: {0}", c1.getLigado());
        Console.WriteLine("---------------------------------");

        // Características do CarroCombate.
        Console.WriteLine("Cor.......: {0}", cc1.cor);
        Console.WriteLine("Nome......: {0}", cc1.nome);
        Console.WriteLine("Rodas.....: {0}", cc1.getRodas());
        Console.WriteLine("Vel.Máxima: {0}", cc1.velMax);
        Console.WriteLine("Ligado....: {0}", cc1.getLigado());
        Console.WriteLine("Municao...: {0}", cc1.municao);
    }
}