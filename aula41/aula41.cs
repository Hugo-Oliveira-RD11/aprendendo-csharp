using System;

class Veiculo{
    private string nome_carro;
    public string nome{
        get{
            return nome_carro;
        }
        set{
            nome_carro=value;
        }
    }
    public Veiculo(){
        nome="";
    }

}
class Aula41{
    static void Main(){
        //string nome="diamante negro";
        Veiculo c1=new Veiculo();
        c1.nome="diamante negro";
        System.Console.WriteLine("o nome do carro e {0}",c1.nome);
        c1.nome="diamante branco";
        System.Console.WriteLine("agora o nome do carro e {0}",c1.nome);
    }
}