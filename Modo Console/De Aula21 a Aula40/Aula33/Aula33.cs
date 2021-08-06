using System;
// Diferença de private e public
// class Jogador{
//     public int energia;
//     public string nome;
//     public Jogador(string nome){ // Método construtor
//         this.nome = nome; // Lembrando que ao utilizar o this estamos nos referindo ao nome do objeto da classe.
//         energia = 100;
//     }
// }
// class Aula33{
//     static void Main(){
//         Jogador j1=new Jogador("Ronaldinho"); // Instanciando um objeto desta classe. Tipo Jogador j1 é o nome do jogador. Operador new pra alocar um espaço na memóra pra esse jogador, o nome da classe e o valor que eu quero passar como o parâmetro de entrada, no caso Ronaldinho.

//         Console.WriteLine("Nome...: {0}", j1.nome); // Acessando os elementos dessa classe.
//         Console.WriteLine("Energia: {0}", j1.energia); // Podemos acessá-las, pois, definimos como public.
//     }

//              Mesmo exemplo anterior, mas agora com o private
    class Jogador{
    private int energia; // Quando definimos um membro como private ele só podeser usado por dentro da classe.
    private string nome;
    public Jogador(string nome){ // Assim não dará certo, pois, as propriedades estão privadas.
        this.nome = nome;
        energia = 100;
    }
    // Se quisermos acessar estes dados precisamos do métod abaixo.
    public int getEnergia(){
        return energia;
    }
    public string getNome(){
        return nome;
    }
    // Mas e se caso, precisarmos alterar o valor de uma propriedade, por exemplo a energia e quisermos que ela deva ficar entre 0 e 100. Se fosse public, qualquer valor seria aceito, então vamos manter como private e precisamos criar um método que vai controlar os valores que são atribuídos à energia.
    public void setEnergia(int e){// Método para controlar e fazer com que a energia digitada esteja entre 0 e 100.
        if(e < 0){
            if(energia+e < 0){
                energia = 0;
            } else {
                energia+= e;
            }
        } else if(e > 0){
            if(energia+e > 100){
                energia = 100;
            } else {
                energia-= e;
            }
        }
    }
}
class Aula33{
    static void Main(){
        Jogador j1=new Jogador("Ronaldinho");

        j1.setEnergia(220);// Atribuindo a energia para a função de set

        // Agora para ter acesso aos elementos da classe que são private, precisamos chamar os métodos getNome e getEnergia e não mais pelo acesso à propriedade.
        Console.WriteLine("Nome...: {0}", j1.getNome()); // Agora para acessar o nome, usamos o getNome 
        Console.WriteLine("Energia: {0}", j1.getEnergia()); // Agora para acessar a energia, usamos o getEnergia.

    }
}