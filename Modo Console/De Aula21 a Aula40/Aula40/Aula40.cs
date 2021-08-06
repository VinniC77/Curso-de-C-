using System;
// Classe Sealed - Uma classe Sealed não pode ser herdada. Se não queremos permitir que uma classe não seja herdade por outra classe derivada, definimos a mesma como sealed.
sealed class Veiculo{

}
class Carro : Veiculo{ // Isso não dará certo, pois a classe Veiculo é sealed(Selada), ou seja, não permite classes derivadas.

}

sealed abstract class Casa{ // Isso nunca vai funcionar, pois, Sealed e abstract são antonimos. No abstract definimos os moldes de métodos para que sejam herdados nas classes derivadas, no Sealed, não estamos permitindo a herança da classe, ou seja, não faz sentido. Nunca usa-se sealed e abstract juntos.

}
// Não permite utilizar o conteito de herança.
class Aula40{
    static void Main(){

    }
}