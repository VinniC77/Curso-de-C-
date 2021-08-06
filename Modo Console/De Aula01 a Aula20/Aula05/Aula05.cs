using System;

class Aula05{
    static void Main(){

        int res = 10;
        bool resu = 10 < 5;
        bool resul = 12 != 7; // diferente
        res++; // res+=1 | res = res + 1 ----- Todas funcionam para incrementar de 1 em 1 | + - / ou *
        res+=2; // | res = res + 2 ----- Para incrementar com mais de 1 em 1. Só destas 2 formas funciona.

        // & = AND / E
        // | = OR / OU

        bool ser = (5 > 3) | (10 < 5); // no OR sendo uma verdadeira já é o suficiente para dar TRUE
        bool sera = (5 > 3) & (10 < 5); // no & sé retorna TRUE quando todas forem verdadeiras

        Console.WriteLine(sera);

    }
}