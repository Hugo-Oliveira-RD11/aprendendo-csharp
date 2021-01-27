//eu coseguir terminar esse projeto!!!!
using System;

public class Players{
    int vida=0;
    bool vivo=false;
    string nome="";

    public Players(int v1,bool v2,string n){
        vida=v1;
        vivo=v2;
        nome=n;

    }
}
public class Cars{
    public int velocidade=0,durabilidade=0;
    
    public Cars(int v,int d){
        velocidade=v;
        durabilidade=d;
    }
}

class jogo{
    static void Main(){
        int num_player=0;
        string nome="";

        System.Console.Write("vão ser quantos jogadores ? [1/2]");
        num_player=Convert.ToInt32(Console.ReadLine());
        if(num_player < 1 | num_player > 2){
            while(num_player < 1 | num_player > 2){
                System.Console.Write("numero errado!\ntente novamente :");
                num_player=Convert.ToInt32(Console.ReadLine());
            }
            criacao_player(num_player);

        }else{
            criacao_player(num_player);

        }

    }
    static void criacao_player(int num){
        string nome1="",nome2,encherlinguica="";


        switch(num){
            case 1:
                System.Console.Write("qual vai ser o seu nome ? ");
                nome1=Console.ReadLine();
                Players player=new Players(100,true,nome1);
                
                criacao_carro(num,nome1,encherlinguica);
                break;
            case 2:
                System.Console.Write("qual vai ser o nome do primeiro jogador ? ");
                nome1=Console.ReadLine();
                Players player1=new Players(100,true,nome1);


                System.Console.Write("qual vai ser o nome do segundo jogador ? ");
                nome2=Console.ReadLine();
                Players player2=new Players(100,true,nome2);
                criacao_carro(num,nome1,nome2);

                break;
        }
    }
    static void criacao_carro(int num,string nome1,string nome2){

        Random random_velo=new Random();
        Random random_dura=new Random();


        if(num == 1){
            Cars cars=new Cars(random_velo.Next(0,100),random_dura.Next(0,100));
            System.Console.WriteLine("o seu carro tem velocidade : {0}\ndurabilidade : {1}",cars.velocidade,cars.durabilidade);
            

        }else if(num == 2){
            Cars cars1=new Cars(random_velo.Next(0,100),random_dura.Next(0,100));
            Cars cars2=new Cars(random_velo.Next(0,100),random_dura.Next(0,100));
            
            System.Console.WriteLine("o carro do {0} tem\nvelocidade : {1} e durabilidade : {2}",nome1,cars1.velocidade,cars1.durabilidade);
            System.Console.WriteLine("E o carro do {0} tem\nvelocidade : {1} e durabilidade : {2}",nome2,cars2.velocidade,cars2.durabilidade);

        }
    }
}