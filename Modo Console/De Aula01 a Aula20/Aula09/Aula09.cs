using System;
class Aula09{
    static void Main(){
        // Operadores de SHIFT - Servem para deslocar os bits dentro de variáveis inteiras << DOBRA e >> corta pela METADE

        int num = 10;
        int nume = 4;

        num = num>>1;
        nume = nume<<2;

        Console.WriteLine(nume);
    }
}