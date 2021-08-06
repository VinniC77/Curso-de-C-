using System;
// Interfaces - Tem uma certa semelhança entre clases abstratas e interfaces, mas as interfaces só implementam métodos ou o protótipo dos métodos. Elas não usa as propriedades nas interfaces.
// Toda classe que implementar uma interface precisa implementar os seus métodos.
// UMa interface não pode ter nem construtor, nem destrutor.
public interface Veiculo{
// Aqui colocamos as assinaturas dos métodos que serão obrigatórios à classe que implementar essa interface.
    void ligar();
    void desligar();
    void info(); 
    // Toda classe que usar essa interface, terá que OBRIGATORIAMENTE usar esses 3 métodos.
}
public interface Combate{
    void disparar();
}
class Carro : Veiculo, Combate{ // Agora, precisamos obrigatoriamente, implementar os métodos da interface Veiculo na classe Carro.
// Para adicionar a interface Combate, basta colcoar depois da vírgula.
    public bool ligado;
    public int municao;
    public Carro(){
        this.municao = 100;
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void info(){
    }
// Lembrando que por Combate, ser uma interface, precisamos OBRIGATORIAMENTE implementar os métodos dela também.
    public void disparar(){

    }
}
class Aula43{
    static void Main(){

    }
}