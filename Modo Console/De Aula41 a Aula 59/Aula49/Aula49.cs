using System;
// Métodos e variáveis estáticos (static)
class Mat{
    public static double pi = 3.14; // Propriedade static
    public static int dobro(int n){ // Método static
        return n * 2;
    }
}
class Aula49{
    static void Main(){
        double vpi = Mat.pi;
        int num = 10;
        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));
        // Assim não precisamos declarar um Objeto Mat pra poder utilizar os métodos e variáveis dele, pois, eles são estáticos.
    }
}