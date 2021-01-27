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
        System.Console.Write("qual e o seu nome ? ");
        nome=Console.ReadLine();

        Player jogador=new Player(nome);    

    }
}

