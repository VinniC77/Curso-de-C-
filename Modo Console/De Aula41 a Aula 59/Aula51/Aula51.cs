using System;
// Argumentos de entrada para usar no programa. - Passando valores para o programa na hora de chamarno terminal.
class Aula51{
    static void Main(string[] args){ // Assim criamos uma lista de argumentos. Criamos um array de strings chamado args que vamos passar na chamada do programa, no terminal.
        if(args.Length > 0){ // Para verificar se foi passado um parametro ou não.
            Console.WriteLine("Quantidade de argumentos {0}", args.Length); // Aqui nos mostrará a quantidade de argumentos digitados.
    // Se quisermos que seja uma função para somar valores.
            int res = 0;
            for(int i = 0; i < args.Length; i++){
                res += Int32.Parse(args[i]); // Assim res, vai receber a soma dos valores colocados no array. Lembrando que precisamos converter para inn, pois, nossa função pega parametros string.
                Console.WriteLine("Argumento {0}: {1}", i, args[i]);
    // Se quisermos verificar os argumentos que foram passados.
            }
            Console.WriteLine("Soma: {0}", res);
            // for(int i = 0; i < args.Length; i++){
            //     Console.WriteLine("Argumento {0}: {1}", i, args[i]); // Assim conseguimos ler a nossa lista de argumentos e saber o que tem nela.
            // }
        } else {
            Console.WriteLine("Não foram passados argumentos");
        }
        
    }
}