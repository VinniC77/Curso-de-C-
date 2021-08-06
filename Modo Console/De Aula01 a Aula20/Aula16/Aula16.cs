using System;
class Aula16{
    static void Main(){
        // Go to

        int tempo = 0;
        char escolha;

        inicio: // Label
        Console.Clear();

        Console.WriteLine("Viagem de Belo Horizonte/MG até Vitória/ES");
        Console.WriteLine("Meio de transporte: [a]Avião | [c]Carro | [o]Onibus");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha) {
            case 'a': 
            case 'A': 
                tempo = 50;
                break;
            case 'c':
            case 'C': 
                tempo = 480;
                break;
            case 'o':
            case 'O': 
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }
        if(tempo < 0) {
            Console.WriteLine("Transporte Indisponível");
        } else {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }
        Console.Write("\nCalcular outro trajeto? [s/n]");
        escolha = char.Parse(Console.ReadLine());
        if(escolha == 's' | escolha == 'S') {
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }
    }
}