//nessa aula eu descobrir como sobreescrever um metodo(função) usando o virtual e overrider,assim da pra fazer metodos padroes, ondem cada metodo faça alguma coisa...

using System;

public class Test{    
    public Test(){
        System.Console.WriteLine("base");
    }
    public virtual void Whoami(){
        System.Console.WriteLine("o teu pai");
    }
}

public class Filho1:Test{
    public Filho1(){
        System.Console.WriteLine("filho1");
    }
    public override void Whoami(){
        System.Console.WriteLine("o teu primo!");
    }
}

public class Filho2:Filho1{
    public Filho2(){
        System.Console.WriteLine("filho2");

    }
    public override void Whoami()
    {
        System.Console.WriteLine("o teu primo 2!");
    }

}

class Aula37{
    static void Main(){
        Test Ref;
        Filho1 filho1=new Filho1();
        Filho2 filho2=new Filho2();        
        
        Ref=filho1;
        Ref.Whoami();

    }
}