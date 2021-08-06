using System;
// Herança - Classe DERIVADA herda membros, propriedades e classes de outra classe, a classe BASE.
// A classe DEIRVADA pode ter seus membros próprios + os membros da classe BASE.

class Veiculo{ // Classe BASE
    public int rodas;
    public int velMax; // Membros da Classe
    private bool ligado;
    public void ligar(){ // Métodos da Classe
        ligado=true;
    }

    public void desligar(){
        ligado=false;
    }
    
    public string getLigado(){
        if(ligado){
            return "Sim";
        } else {
            return "Não";
        }
    }
}

class Carro:Veiculo{ // Classe Carro é derivada da classe Veiculo. Nesse caso a classe Carro herda os membros e métodos da classe Veiculo. 
    // Mesmo que não implemente nada, ela já possui os membros da clase Veiculo, pois estes são public.
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

class Aula34{
    static void Main(){
        Carro c1=new Carro("Rapidão", "Vermelho"); // Carro da classe Carro chamado c1. Quando instanciamos um novo carro, precisamos passar um novo nome e cor.

        Console.WriteLine("Cor.......: {0}", c1.cor); // Agora podemos acessar todos os membros que foram public.
        Console.WriteLine("Nome......: {0}", c1.nome);
        Console.WriteLine("Rodas.....: {0}", c1.rodas);
        Console.WriteLine("Vel.Máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado....: {0}", c1.getLigado());
    }
}