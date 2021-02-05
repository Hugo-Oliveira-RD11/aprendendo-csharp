//hoje eu aprendi que o Main(metodo/funcao),nao precisa ficar em uma classe separada, 
//e sobre o interface, que e como se fosse uma base para as classes que vão herdar ele

using System;
interface Player
{
    public int vida(int vida);
    public int estamina(int estamina);

}
interface Armas
{
    public int balas(int balas);
    public int pistola(int pistola);
}

class Jogo:Player,Armas
{
    static void Main()
    {
        Jogo partida1=new Jogo();
        System.Console.WriteLine( "a sua é {0}\na sua estamina é {1}\na sua munição é {2}\na quantidade de armas são {3}",partida1.vida(-1),partida1.estamina(-1),partida1.balas(-1),partida1.pistola(-1));
    }
    public int life;
    public int vida(int vida){
        if(vida > 100){
            return life=100;
        }else if(vida < 0){
            return life=0;
        }else{
            return life=vida;
        }
    }


    public int folego;
    public int estamina(int estamina){
        if(estamina > 100){
            return folego=100;
        }else if(estamina < 0){
            return folego=0;
        }else{
            return folego=estamina;
        }
    }

    public int municao;
    public int balas(int balas){
        if(balas > 1000){
            return municao=1000;
        }else if(balas < 0){
            return municao = 0;
        }else
        {
            return municao=balas;
        }
    }

    public int arma;
    public int pistola(int pistola){
        if(pistola>4){
            return arma=4;
        }else if(pistola<0){
            return arma=0;
        }else{
            return arma=pistola;
        }
    }


    public Jogo(){}
}
