//cheguei no 30 eeeeeeeeeeeeeeeeeeeeeeeee
// aqui aprendir a estorar os construtores
using System;


public class Player{
    public int life;
    public bool vivo;
    public string nome;
    
    public Player(string n){
        life=100;
        vivo=true;
        nome=n;
    }
    public Player(string n,int l){
        life=l;
        vivo=true;
        nome=n;
    }
    

}



class Aula28{
    static void Main(){
        string nome;
        int vida;
        System.Console.Write("qual e o nome do primeiro jogador ? ");
        nome=Console.ReadLine();
        Player jogador=new Player(nome);
        
        System.Console.Write("qual e o nome do segundo jogador ? ");
        nome=Console.ReadLine();
        Player jogador2=new Player(nome,80);

        System.Console.WriteLine("o jogador {0} tem de vida {1}\ne o jogador {2} tem de vida {3}",jogador.nome,jogador.life,jogador2.nome,jogador2.life);

    }
}

