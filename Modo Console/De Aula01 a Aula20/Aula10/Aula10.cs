using System;
class Aula10{
    // ENUM - Criar um tipo e definir os tipos que esse valor pode receber
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado}; // Os valores possíveis para esse tipo DiasSemana foram definidos dentro da chave.
    static void Main(){
        DiasSemana ds = DiasSemana.Quarta; // DiasSemana é o tipo
        DiasSemana dd = (DiasSemana)0; // acessando através do índice

        // // Também podemos fazer o contrário, ou seja, verificar qual número se refere ao dia

        int ss = DiasSemana.Sexta; // Dará erro ao compilar pq o tipo int não é um tipo válido nesse caso.
        int sss = (int)DiasSemana.Sexta; // Isso está dizendo: Converta esse valor de DiasSemana.Sexta em um inteiro. Que será o índice de Sexta, que é 5.

        Console.WriteLine(sss);
    }
}