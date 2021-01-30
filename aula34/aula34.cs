using System;

class Veiculo{ //vou usar o mesmo exemplo, so porque eu não tive outra ideia!
    public bool ligado;
    public int velocidade;

    public Veiculo(){
        ligado=false;
        velocidade=0;
    }
    public int kmh(int velocidade)
    {
        return this.velocidade=velocidade;
    }


    }


class Carro : Veiculo{
    string nome;
    string cor;
    public Carro(string nome,string cor,bool ligado,int velocidade){
    estado(ligado);
    this.nome=nome;
    this.cor=cor;
    kmh(velocidade);
    }
    public bool estado(bool ligado){
        return (ligado?this.ligado=ligado:this.ligado=false);
    }
    public bool SetLigado(){
        return ligado;
    }

    public string SetNome(){
        return nome;
    }
    public string SetCor(){
        return cor;
    }
    public int SetKmh(){
        return velocidade;
    }

}

class Aula34{
    static void Main(){
        bool estado=false;
        string carro="",cor="";
        int velocidade=0;
        char opt='4';
        for(int i=1;i<5;i++){
            System.Console.Write("qual e ");
            
            switch(i){
                case 1:
                    System.Console.Write(" o carro que vc quer ? ");
                    carro=Console.ReadLine();
                    break;
                case 2:
                    System.Console.Write(" a cor que vc quer ? ");
                    cor=Console.ReadLine();
                    break;
                case 3:
                    System.Console.Write(" a velocida maxima que vc quer ? " );
                    velocidade=Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    System.Console.Write(" vc quer ele ligado ? [S/n] ");
                    opt=Convert.ToChar(Console.ReadLine());
                    if(opt == 's' | opt == 'S'){
                        estado=true;
                    }
                    break;
           }  
                    
        }




        Carro carro1=new Carro(carro,cor,estado,velocidade);

        estado=carro1.SetLigado();


        System.Console.Write("o carro e {0}, tem a cor {1}, esta ",carro1.SetNome(),carro1.SetCor());

        if(estado == true){
            System.Console.Write("ligado");

        }else{
            System.Console.Write("desligado");
        }

        System.Console.Write(" e corre a {0}\n",carro1.SetKmh());
    }


}