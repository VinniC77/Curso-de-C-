using System;
// Sobrecarga de Métodos
class Calc{
    public int soma(int n1, int n2){ // Método
        return n1 + n2;
    } // Se precisarmos passar mais valores para somar, entra o conceito de sobrecarga.
    public int soma(int n1, int n2, int n3){ // Basta criarmos um método soma com o mesmo parâmetro. Podem existir métodos com o mesmo nome, desde que eles tenham lista de argumentos diferentes.
        return n1 + n2 + n3;
    }
    // Se quisermos que o méodo soma possa somar valores com casas decimais, precisamos expecificar isso.
    public double soma(double n1, double n2, double n3){ // Basta criarmos um método soma com o mesmo parâmetro. Podem existir métodos com o mesmo nome, desde que eles tenham lista de argumentos diferentes.
        return n1 + n2 + n3;
    }
    // Mas e se quisermos passar um número indeterminado de parâmetros.
    public int soma(params int[]n){
        int somador = 0;
        for(int i = 0;i < n.Length; i++){
            somador += n[i];
        }
        return somador;
    }
    public double soma(params double[]n){
        double somador1 = 0;
        for(int i = 0;i < n.Length; i++){
            somador1 += n[i];
        }
        return somador1;
} // Agora temos uma função que soma inteiros e outra que soma doubles. Essa é a sobregarga de métodos. E tanto faz qual tipo de número queremos somar.
    class Aula47{
        static void Main(){
            // Criando / instanciando um objeto da classe Calc
            Calc calc=new Calc();
            var res = calc.soma(10.1, 2.2, 3.4, 5, 88);
            Console.WriteLine(res);
            // Assim podemos chamar o método soma com 2 ou 3 valores.
        }
    }
}