using System;
// Classes e métodos abstratos. Quando eu declaro uma classe abstrata ela servirá como base de referencia para outras classes que vão herdar a classe abastrata.
// Em métodos abstratos não implementamos o comportamento do método, nós só criamos o protótipo que vai servir como referencia pras classes que estão herdando da classe abastrata.
// OBS.: Não podemos instanciar/criar objetos de classes abstratas.
abstract class Veiculo{ // Classe base abstrata.
    protected int velMax;// protected permite acesso nas classes derivadas
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){ // Método para ligar o carro. Este método não é abstrato, portanto, precisamos implementar a sua funcionalidade.
        this.ligado = ligado;
    }
    public int getVelAtual(){ // Método para retornar a velocidade atual.
        return velAtual;
    }
    abstract public void aceleracao(int mult); // Por ser um método abstrato, eu vou ser obrigado a implementar o método aceleracao() na classe deriviada. Aqui não há necessidade de implementação.
}
// Não podemos instanciar um objeto da classe Veiculo, pois, ela é abstrata, mas podemos utilizá-la como classe base para passar a sua herança para uma classe derivada.
class Carro : Veiculo{ // classe Carro derivada da classe Veiculo.
    public Carro(){
        velMax = 120; // Como o método é protected, podemos acessá-lo em classes derivadas.
    }
    override public void aceleracao(int mult){ // Aqui somos obrigados a implementar o método aceleracao(), pois, é um método abastrato na classe base.
        velAtual += 10 * mult;
    }
}
class Aula39{
    static void Main(){
        Carro carro1=new Carro();
        // Aumentando a velocidade do carro.
        carro1.aceleracao(2);
        Console.WriteLine(carro1.getVelAtual());
        // Diminuindo a velocidade do carro.
        carro1.aceleracao(-1);
        Console.WriteLine(carro1.getVelAtual());
        // Aumentando de novo a velocidade do carro.
        carro1.aceleracao(3);
        Console.WriteLine(carro1.getVelAtual());
    }
}