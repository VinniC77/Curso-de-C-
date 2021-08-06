using System;
class Aula13{
    static void Main(){
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string final;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;
        // >= 60 - Aprovado.
        // > 40 & > 59 - Recuperação.
        // < 40 - Reprovado.

        if(res < 40) {
            final = "Reprovado";
        }else if(res < 60) {
            final = "Em recuperação";
        }else{
            final = "Aprovado";
        }
        Console.Write("Média Final: {0} - Resultado: {1}", res, final);

    }
}