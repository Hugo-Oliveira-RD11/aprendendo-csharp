//aqui aprendir a usar o private, e um pouco do return...

using System;

class Player{
    private string nome;
    private int vida;

    public Player(string nome,int vida){
        this.nome=nome;
        this.vida=vida;
    }

    public string GetNome(){
        return nome;
    }
    public int GetVida(){
        return vida;
    }

    public int SetVida(int vida){
        if(vida<0){
            if(this.vida+vida < 0){
                return this.vida=0;
            }else{
                return this.vida+=vida;
            }
        }else{
            if(this.vida+vida > 100){
                return this.vida=100;
            }else{
                return this.vida+=vida;
            }

        }
    }

}


class Aula33{
    static void Main(){
        Player p1=new Player("hugo",100);
        System.Console.WriteLine("o {0} tem {1} de vida",p1.GetNome(),p1.GetVida());

        p1.SetVida(-130);
        System.Console.WriteLine("agora a vida do {0} é {1}",p1.GetNome(),p1.GetVida());


    }
}