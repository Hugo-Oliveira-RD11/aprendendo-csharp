using System;
interface Player
{
    public int vida(int vida);
    public int estamina(int estamina);

}
interface Armas
{
    public void balas();
    public void pistola();
}

class Jogo:Player,Armas
{
    static void Main()
    {
        Jogo partida1=new Jogo();
        System.Console.WriteLine( "a sua é {0}\n{1}",partida1.vida(50),partida1.estamina(30));
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


    public Jogo(){}
}
