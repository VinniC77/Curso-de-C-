using System;
// Indexadores de Classes - É um membro de uma classe que vai permitir aos objetos dessa classe serem indexados como se fossem arrays. Podemos usar os objetos de classes que possuem indexador como se fossem arrays.
class Carro{
    private int[] velMax = new int[5]{80, 120, 180, 200, 300};

    public int this[int i]{ // É o this que define que é um indexador. O i faz referência ao índice do array.
        get{ // Podemos usar os acessors nos indexadores.
            return velMax[i]; // A diferença é que precisamos indicar a posição do, agora objeto, dentro do array.
        }
        set{
            if(value < 0){
                velMax[i] = 0;
            } else if(value > 300){
                velMax[i] = 300;
            } else {
                velMax[i] = value; 
            }
        }
    } 
    
    
    
    public Carro(){
    }
}
class Aula42{
    static void Main(){
        Carro c1=new Carro();
        // Na instanciação/criação do objeto precisamos indicar o indice
        c1[4] = 200; // Aqui estamos utilizando o set (atribuindo valor) ao índice 4 do array.
        Console.WriteLine("Velocidade: {0}", c1[4]); // Aqui estamos lendo (get) o indice 4 do array.
        //E só conseguimos utlilizar o objeto como o array porque temos o indexador.
    }
}