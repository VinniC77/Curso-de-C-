using System;
// Tratamenro de Exceções / Try Catch Finanlly - Uma exceção é um erro. Toda exceção é representada por uma class, que é derivada de uma classe Exception. Então precisamos criar essas exceções para que quando ocorrerum erro, não seja paralizado o programa ou que não exiba o erro para o cliente. Precisamos fazer o tratamento desses erros.
class Aula52{
    static void Main(){
        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0; // Se tentarmos dividir qualquer número por zero, teremos um erro como retorno. Então podemos tratar esse erro.
        try{ // Tente executar este bloco
            res = n1 / n2;
            Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
        // } catch { // MODO GENÉRICO DE TRATAMENTO DE EXCEÇÕES. Caso não consiga, ele vai tratar esse erro e cair neste bloco catch.
        //     Console.WriteLine("Erro!");
        // }
        } catch (Exception e){ // Nos parametros do catch, podemos interceptar qual foi a mensagem de erro e emitir essa mensagem. Declarando um componente do tipo Exception.
            Console.WriteLine("Erro: {0}", e.Message); // O e recebe a exceção e podemos mostra a mensagem deste erro ao colocar depois do ponto o Message, mas existem outros tipos de opções dentro de e.
        }
    } // Se não ocorrer nenhum erro, ele executa o try normalmente.
}