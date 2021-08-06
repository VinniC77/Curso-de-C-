using System;
// Métodos que retornam Objetos
class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){ // Método Construtor Galinha
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    // Vamos criar um métod na classe Galinha, para botar um ovo. Esse é o método que vai retornar um Objeto.
    // O método botar(), vaor retornar um Objeto do Tipo Ovo.
    public Ovo botar(){// public - Acesso do método / Ovo - tipo de retorno do método / botar - nome do método
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}
class Ovo{
    // Criando um controle de ovos para a galinha.
    // Para cada ovo que a galinha criar vou passar o parametro numOvo;
    private int numOvo;
    // Controlando a qual galinha o ovo pertence.
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){ // Método Construtor Ovo
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
    // Agora além do ovo ser criado, ele tem um número e o nome da galinha que o colocou.
        Console.WriteLine("Ovo Criado: {0}, da galinha {1}", this.numOvo, this.minhaGalinha);
    }
}
class Aula46{
    static void Main(){
        // Instanciando / Criando novas galinhas.
        Galinha g1=new Galinha("Caramelo");
        Galinha g2=new Galinha("D'Angola");
        Galinha g3=new Galinha("Papo de Bago");
        // Se quisermos que a galinha bote um ovo, basta chamarmos o método.
        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();
    }
}