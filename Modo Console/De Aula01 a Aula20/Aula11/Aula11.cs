using System;
class Aula11{
    static void Main(){
        // Tape e Cast - Quando precisamos converter um tipo em outro.

        int n1 = 10; 
        float n2 = n1; // Conversão segura / Implícita

        float n3 = 10.5f;
        int n4 = n3; // Nesse caso não é possível fazer essa conversão segura, pois, não é explícita.

        float n3 = 11.4f;
        int n4 = (int)n3; // Temos que dar um type cast

        Console.WriteLine(n4);
    }
}