using System;
// Estruturas (struct) - É definir um tipo que vai permitir o armazenamento de dados de diferentes tipos.
// Um struct pode armazenar tipos de dados diferentes.
// Struct é diferente de classe, struct é tratada como tipo value e class é tratada como tipo de referencia. Isso significa que os membros da struct são acessados diretamente e não por referencia.
// Não pode herdar e nem servir de base para uma classe, mas podemos usar construtores nas structs.
struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor){ // Método construtor
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info(){
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}
class Aula44{
    static void Main(){
        Carro c1; // c1 é uma variável do tipo Carro (criado com a struct)

        c1.marca = "VW";
        c1.modelo = "Golf";
        c1.cor = "Branco";

        Console.WriteLine("Marca.: {0}", c1.marca);
        Console.WriteLine("Modelo: {0}", c1.modelo);
        Console.WriteLine("Cor...: {0}", c1.cor);
        Console.WriteLine("-----------------------");

        // Mas como temos um método construtor que atribui valor a estes elementos, não precisamos atribuir com o c1.marca = "Alguma coisa". Basta chamar o método construtor na declaração do objeto.
        Carro c2=new Carro("HB20", "Hyundai", "Vermelho");
        //Também podemos criar um método construtor para exibir as informações dos carros criados e depois só chamá-lo a partir do objeto passado.
        c2.info();
    }
}