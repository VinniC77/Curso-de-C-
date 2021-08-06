using System;
// Acessors GET e SET - São propriedades especiais onde elas são flexíveis e nos permitem ler, atribuirou calcular um valor pelas propriedades acessors. Misturam os conceitos de prorpriedade e métodos.
class Carro{
    private int velMax; // por ser prvivate não podemos acessá-la fora da classe.
// Com as propriedades acessors, podemos ler(get) e alterar(set) o valor dessa propriedade.
    public int vm{
        get{ // leitura da propriedade, ou seja, obtendo um valor da propriedade.
            return velMax;
        }
        set{ // escrita (alteração) da propriedade, ou seja, atribuindo um valor à propriedade. Quando atribuimos um valor, este é armazenado na value. Então podemos usá-lo a qualquer momento. Neste caso vamos limitar a velocidade de 0 a 300. Se for atribuído menos que 0 o valor será zero, se for atribuído um valor maior que 300, o valor será 300. Para limitar a este intervaldo.
            if(value < 0){
                velMax = 0;
            } else if(value > 300){
                velMax = 300;
            } else {
                velMax = value; 
            }
        } // Assim nós definimos a propriedade acessors vm para poder manipular a propriedade private velMax.
    } 
    
    
    // Não é obrigatório colocar as duas (get e set)se não quiser.
    public Carro(){ // Construtor
        // this.velMax = 120;
        vm = 120; // Assim, podemos usá-la já aqui.
    }
}
class Aula41{
    static void Main(){
// Ou também na instanciação.
        Carro c1=new Carro();
        // Se quisermos atribuir um novo valor a vm, basta usar o = para a atribuição.
        c1.vm = 200; // Aqui está usando o acessor SET (para atribuir o valor)
        Console.WriteLine("Velocidade: {0}", c1.vm); // Aqui está usando o acessor GET (para ler o valor)
        // Não podemos acesar a velMax que é private, mas temos acesso ao acessors vm.
    }
}