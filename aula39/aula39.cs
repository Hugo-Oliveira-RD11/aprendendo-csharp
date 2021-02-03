//não tive nem uma ideia do que fazer com o metodo abstract

using System;

abstract class Veiculo{
    public int velMax;
    public string nome;
    public Veiculo(){
        velMax=0;
        nome="";
    }

}
class MeuFusca:Veiculo{
    public MeuFusca(string nome,int velMax){
        this.nome=nome;
        this.velMax=velMax;
    }
}

class Aula39{
    static void Main(){
        string nome="o diamante negro";
        int velMax=520;
        MeuFusca fusca=new MeuFusca(nome,velMax);
        System.Console.WriteLine("o nome do meu fusca e {0}\ne a velocidade maxima dele é {1}km",fusca.nome,fusca.velMax);

    }
}