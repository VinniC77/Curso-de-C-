using System;
// Namespaces - O Namespece surge para controlar o escopo. É um método de organização e podemos classificar os elementos dentro do namespaces. Conseguimos determinar áreas e separar as classes por tipo através do namespace.
namespace Calc1{ // Agora a classe Area está dentro do escopo deste namespace. Não podemos ter 2 classes com o mesmo nome dentro do mesmo namespace.
    class Area{ 
    public static float Quad(float bas, float altura){
        if(bas == 0 || altura == 0){

            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas * altura;
    }
}
}
namespace Calc2{
    class Area{ // Mas podemos ter uma classe com o mesmo nome dentro de outro namespace. Outro escopo, simplesmente.
    public static float Quad(float bas, float altura){
        if(bas == 0 || altura == 0){

            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas * altura;
    }
}
}
class Aula53{
    static void Main(){
        float area = 0;
        try {
            area = Calc1.Area.Quad(12f, 5f); // Precisamos mencionar em qual namespace(escopo) a classe área está.
            Console.WriteLine("Área do Quadrado: {0}", area);
        } catch(Exception e) {
            Console.WriteLine("ERRO: {0}", e.Message);
        } finally {
            Console.WriteLine("Fim do Processo");
        }
    }
}