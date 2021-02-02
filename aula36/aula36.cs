//public pode ser acessodo por geral..
//private pode ser acessado so pela propria classe
//protected pode ser acessado pela propria classe, e de quem herdar ela(a sua propria classe)
//um dia eu voltou aqui pra terminar o projeto!
using System;

class Pc{
    protected string gabinete;
    protected string processador;
    protected string placa_mae;

    public string SetGabinete(){
        return gabinete;
    }

    public string SetProcessador(){
        return processador;
    }

    public string SetPlaca_mae(){
        return placa_mae;
        
    }
        public void mostrar(){
        
            System.Console.Write("o seu teclado e {0}\nsua tv/monitor e {1}\nseu mouse e {2}\nsua cadeira e {3}\n",this.teclado,this.monitor,this.mouse,this.cadeira);
            System.Console.Write("o seu pc tem uma gabinete de {0}\nprocessador {1}\nplaca mãe {2}",this.gabinete,this.processador,this.placa_mae);
            System.Console.WriteLine("obrigado pela sua compra!\nvolte sempre");
            Environment.Exit(0);
        
        }


    
    public Pc(string gabinete,string processador,string placa_mae){
        this.gabinete=gabinete;
        this.processador=processador;
        this.placa_mae=placa_mae;
        mostrar();
    
    }

    
}
class Desktop:Pc{
    public string teclado;
    public string monitor;
    public string mouse;
    public string cadeira;
    public Desktop(string teclado,string monitor,string mouse,string cadeira,string lixo):base(lixo,lixo,lixo){
        this.teclado=teclado;
        this.monitor=monitor;
        this.mouse=mouse;
        this.cadeira=cadeira;
        mostrar2();
        
    }
    
    public void mostrar2(){
        System.Console.Write("o seu teclado e {0}\nsua tv/monitor e {1}\nseu mouse e {2}\nsua cadeira e {3}\n",this.teclado,this.monitor,this.mouse,this.cadeira);
        System.Console.WriteLine("obrigado pela sua compra!\nvolte sempre");
        Environment.Exit(0);
    }
}

class Aula36{
    static void Main(){
        confi_desktop();

    }

    static void confi_desktop(){
        
        string teclado,monitor,mouse,cadeira,lixo="nada";
        char opcao='n';
        

        System.Console.Write("qual teclado vc quer ?");
        teclado=System.Console.ReadLine();
        
        System.Console.Write("qual monitor vc quer ?");
        monitor=System.Console.ReadLine();
        
        System.Console.Write("qual mouse vc quer ?");
        mouse=System.Console.ReadLine();
        
        System.Console.Write("qual cadeira vc quer ?");
        cadeira=System.Console.ReadLine();

        while((opcao != 'S') && (opcao != 'N') && (opcao != 's') && (opcao != 'n')){
            System.Console.Write("vc que um pc ?[S/n]");
            opcao=Convert.ToChar(System.Console.ReadLine());
            
        }
        switch(opcao){
            case 'S':
            case 's':
                confi_pc();
                break;
            default:
                Desktop MyDesktop=new Desktop(teclado,monitor,mouse,cadeira,lixo);    
                break;
        }
    }

    static void confi_pc(){

        string processador,placa_mae,gabinete;
        
        System.Console.Write("qual processador vc quer ?");
        processador=System.Console.ReadLine();
        
        System.Console.Write("qual placa mae vc quer ?");
        placa_mae=System.Console.ReadLine();    
        
        System.Console.Write("qual gabinte vc quer ?");
        gabinete=System.Console.ReadLine();
        
        Pc Mypc=new Pc(gabinete,processador,placa_mae);

    }
}