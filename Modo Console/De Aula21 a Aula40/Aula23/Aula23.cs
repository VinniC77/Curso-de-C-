using System;
class Aula23{
    static void Main(){
        // Métodos de Array
        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[,] matriz=new int[2, 5]{{11, 22, 00, 44, 55},{66, 77, 88, 99, 00}};

        Random random=new Random(); // classe Random serve pra gerar números aleatórios.
        for(int i=0; i<vetor1.Length; i++){
            vetor1[i] = random.Next(50); // Método Next a cada iteração ele sorteia um número e e coloca na posicção do vetor, sendo 50 o valor máximo.
        }

        Console.WriteLine("Elementos do Vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        // public static int BinarySearch(array, valor);
        // Esse método traz um número inteiro que é a posição do elemento procurado. Caso não encontre esse valor no array ele retorna -1.
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos=Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("-------------------------------------------");

        // public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
        // Método Copy faz uma cópia dos elementos de um array pra outro. 
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length); // o vetor 2 recebe os elementos do vetor 1. No caso todos, por causa do length.
        foreach(int n in vetor2){ // com o forEach, nesse caso irá passar por todos os elementos do vetor 2.
            Console.WriteLine(n); // E irá imprimí-los no console.
        }
        Console.WriteLine("--------------------------------------------");

        // public void CopyTo(Ar_destino, a_partir_desta_pos);
        // Tem a mesma funcionalidade do Copy, mas é invocado a partir do vetor de origem.
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0); // mas nesse caso especifica a partir de qual posição. No caso a partir da posição 0, ou seja, todos. Todos os elementos do vetor 1 serão copiados no vetor 3.
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------");

        // public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("---------------------------------------------");

        // public void GetLowerBound(dimensão);
        // Esse método retorna o índice com o MENOR valor do array ou matriz. Se for um array, o "dimensão" é 0. Se for uma matriz, tem que informar qual dimensão eu quero obter o menor índice. 
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0); // Array, dimensão 0.
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1); // Matriz, neste caso a 2 "linha", portanto, 1.
        Console.WriteLine("Menor Índice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("---------------------------------------------");

        // public void GetUpperBound(dimensão);
        // Esse método retorna o índice com o MAIOR valor do array ou matriz. O contrário do GetLowerBound.
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("---------------------------------------------");

        // public void GetValue (long indice);
        // Retorna um objeto a partir de um índice. Se quiser o número do índice é preciso fazer um cast.
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3)); // convertendo pra inteiro
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3)); // 2 valores, pois, é uma matriz
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("---------------------------------------------");

        // public static int IndexOx(array, valor);
        // Retorna o índice do valor indicado no segundo parâmetro. Retorna o índice do PRIMEIRO valor informado que ele encontrar. Se tiver 3 valores iguais, só retorna o PRIMEIRO.
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("---------------------------------------------");

        // public static int LastIndexOf(array, valor);
        // Retorna o índice do valor indicado no segundo parâmetro. Retorna o índice do ÚLTIMO valor informado que ele encontrar. Se tiver 3 valores iguais, só retorna o ÚLTIMO.
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do ultimo valor 3: {0}", indice2);
        Console.WriteLine("---------------------------------------------");

        // public static void Reverse(array);
        // O reverse inverte a ordem dos elementos do array
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        // public void SetValue(object valor, long pos);
        // SetValue permite setar/definir um valor a uma posição.
        vetor2.SetValue(99, 0); // Definindo 99 para a posição 0.
        for(int i=0; i < vetor2.Length; i++){
            vetor2.SetValue(0, i); // Com o for definindo 0 para todas as posições do vetor2.
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        // public static void Sort(Array);
        // Método Sort serve para ordenar em ordem crescente os elementos do array. Para fazer de forma decrescente pode-se usar o reverse depois do Sort.
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor 1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
    }
}