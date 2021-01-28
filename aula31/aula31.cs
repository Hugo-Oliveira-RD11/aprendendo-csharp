using System;

class Inimigo{
    static public bool atencao=false;
    public string frase="";


}

class Aula31{
    static void Main(){
        Inimigo dartvaide=new Inimigo();
        Inimigo jason=new Inimigo();
        Inimigo you=new Inimigo();

        dartvaide.frase="o lado negro e sempre melhor!";
        jason.frase="da pra resolver quase tudo no machado...";
        you.frase="que diabos e isso ? ";

        //System.Console.WriteLine(Inimigo.atencao);
        
        Inimigo.atencao=true;
        
        System.Console.WriteLine("a frase do dart vaider\n {0}",dartvaide.frase);
        System.Console.WriteLine("{0}\n",Inimigo.atencao);

        System.Console.WriteLine("a frase do jason\n {0}",jason.frase);
        System.Console.WriteLine("{0}\n",Inimigo.atencao);

        System.Console.WriteLine("a sua frase you\n {0}",you.frase);
        System.Console.WriteLine("{0}\n",Inimigo.atencao);




    }
}