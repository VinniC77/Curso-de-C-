using System;
class Aula12{
    static void Main(){
        // IF
        // int nota = 55;
        // // if(nota >= 60) {
        // //     Console.WriteLine("Aprovado");
        // // }

        // string resultado = "Reprovado";
        // if(nota >= 60) {
        //     resultado = "Aprovado.";
        // }
        // Console.WriteLine("Resultado: {0}", resultado);

        // int nota = 0;
        // Console.Write("Digite sua nota: ");
        // nota = int.Parse(Console.ReadLine());
        // string result = "Reprovado";
        // if(nota >= 60) {
        //     result = "Aprovado";
        // }
        // Console.WriteLine("Resultado: {0}", result);

        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string final = "Reprovado";

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;

        if(res >= 60) {
            final = "Aprovado";
        }
        Console.Write("Média Final: {0} - Resultado: {1}", res, final);

    }
}