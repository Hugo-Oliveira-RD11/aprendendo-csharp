using System;


public class Player{
    public int life,balas;
    public bool vivo,colete;
    public string nome;
    public Player(){
        life=100;
        balas=0;
        vivo=true;
        colete=false;
        nome="lidão!";
    }

}



class Aula28{
    static void Main(){
        Player p1=new Player();

        System.Console.Write("qual vai ser o seu nome : ");
        p1.nome=Convert.ToString(System.Console.ReadLine());
        System.Console.Write("vc estar com {0} de vida\nvc tem {1} balas\n",p1.life,p1.balas);
        if(p1.colete == true){
            System.Console.Write("vc tem colete!\n");
        }else{
            System.Console.Write("vc não tem colete!\n");
        }
        System.Console.WriteLine("espero que se divitar {0}",p1.nome);       
    }
}