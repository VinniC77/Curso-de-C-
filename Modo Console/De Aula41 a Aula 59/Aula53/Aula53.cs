using System;
// Tratamenro de Exceções / Bloco Finally.
// Criando uma classe para calcular a área de um quadrado
class Area{ 
    public static float Quad(float bas, float altura){
        if(bas == 0 || altura == 0){
    // Não se pode calcular um quadrado se a base ou a altura forem 0. Então disparamos um erro.
            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas * altura;
    }
}
class Aula53{
    static void Main(){
        float area = 0;

        try {
            area = Area.Quad(0, 5f);
            Console.WriteLine("Área do Quadrado: {0}", area);
        } catch(Exception e) {
            Console.WriteLine("ERRO: {0}", e.Message);
        } finally {
            Console.WriteLine("Fim do Processo");
        }
    //     int n1, n2, res;
    //     res = n1 = n2 = 0;

    //     n1 = 10;
    //     n2 = 2;
    //     try { 
    //         res = n1 / n2;
    //         Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
    // // E se quisermos disparar nossa própria exceção. (Mesmo que não dê um erro para cair no catch).
    // // Mesmo que não dê erro aqui, com o throw podemos forçar um erro.
    //     throw new Exception("CFB Cursos");
    //     } catch(Exception e){
    //         Console.WriteLine("Erro: {0}", e.Message);
    //     } finally { // Este bloco será executado, independentemente se for disparada a exceção ou não. Ou seja, tanto sendo executado o try como o catch.
    // //         Console.WriteLine("Fim do Processo");
    //     }
    }
}