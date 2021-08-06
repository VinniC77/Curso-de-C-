using System;
//          Classes e Objetos - POO (Programação Orientada a Objetos.)
//          Os 4 pilares da POO são: Abstração, Encapsulamento, Herança e Polimorfismo.
// Criando a classe jogador:
public class Jogador{ // Toda classe DEVE começar com a letra MAIÚSCULA. (Boa prática). public pq não usa nenhum modificador.
    public int energia = 100; // Essas são as propriedades da classe.
    public bool vivo = true; // Podemos definir ou não essas propriedades.
}

class Aula28{
    static void Main(){
    // Criando um objeto da classe Jogador:
        Jogador r10 = new Jogador(); //Jogador é o tipo do obejto, r10 é o nome. Instanciei um novo objeto da classe Jogador com o nome r10.
        Jogador r9 = new Jogador(); // Cada jogador é um objeto indepedente.
        Jogador r11 = new Jogador();
        r10.energia = 70; // Como a propriedade é pública também é possível alterá-la para o objeto que desejarmos que ela altere.
        Console.WriteLine("Energia do jogador r10: {0}", r10.energia); // ao digitar o ponto depois do nome do novo objeto criado, já lista as propriedades dele, porque elas são públicas (public), ou seja, é possível acessá-las fora da classe em que elas foram criadas.
        Console.WriteLine("Energia do jogador r9: {0}", r9.energia); // Como cada jogador é independente, e a do r9 não foi alterada, neste caso se mantém em 100.
        

    }
}

//   [ModificadorClasse] class NOME_DA_CLASSE {
//      Variáveis / Propriedades
//   [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

//      Métodos
//  [EspecificadorAcesso] retorno NOME_MÉTODO([arg1, ...]){
//          Corpo do Método
//  }
//}

//      ModificadorClasse: Define a visibilidade da classe
//          public: Pública, sem restrição de visualização
//          abstract: Classe-base para outras classes. Não podem ser instanciados os objetos des classe.
//          sealed: Classe não pode ser herdada.
//          static: Classe não permite a instanciação de objetos e seus membros devem ser static.

//      Especificadores de Acesso: Onde um membro da classe pode ser acessado.
//          public: Sem restição de acesso.
//          private: Só podem ser acessados pela própria classe.
//          protected: Podem ser acessados na própria classe e nas classes derivadas.
//          abstract: Os métodos não tem implementação, somente os cabeçalhos.
//          sealed: O método não pode ser redefinido.
//          virtual: O método pode ser redefinido em uma classe derivada.
//          static: O método pode ser chamado mesmo sem a instanciação de um objeto.