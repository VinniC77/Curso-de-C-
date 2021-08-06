using System;
class Aula26{
    static void Main(){
        // Argumento Out - Permite que o método possa retornar mais que um valor de saída.
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 3;
        quoc = divisaoEResto(divid, divis, out rest); // É preciso por out na frente para trazer a 2ª saída.
        Console.WriteLine("{0}, dividido por {1} é: {2} e o resto da divisão é: {3}", divid, divis, quoc, rest);
        // Podemos adicionar quantas saídas quisermos, basta colocar nos parâmetros com o argumento Out na frente.
    }
    static int divide(int dividendo, int divisor){ // Neste caso int (não void) pq queremos retornar um valor.
        int quociente;
        quociente = dividendo / divisor;
        return quociente; // Neste caso retornaria um único valor. O resultado da divisão.
    }
    // Mas e se quiséssemos que retornasse o resultado e também o resto da divisão?
    static int divisaoEResto(int dividendoo, int divisorr, out int resto){ // Assim temos a possibilidade de ter 2 saídas no método. Com o método Out, tanto o resultado da divisão, quanto o resto da divisão.
        int quociente1;
        quociente1 = dividendoo / divisorr;
        resto = dividendoo % divisorr;
        return quociente1;
    }
}