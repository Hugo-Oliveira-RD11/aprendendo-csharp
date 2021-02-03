using System;
abstract class MateriaPrima{
    public int madeira;
    public int ferro;
    public int plastico;
    public int ceramica;
    public MateriaPrima(){
        madeira=0;
        ferro=0;
        plastico=0;
        ceramica=0;
    }

}
sealed class ProdutoFinal:MateriaPrima{

    private string nome_produto;
    private string fornecedor;
    public ProdutoFinal(string fornecedor,string nome_produto,int madeira,int ferro,int plastico,int ceramica){
        this.fornecedor=fornecedor;
        this.nome_produto=nome_produto;
        this.madeira=madeira;
        this.ferro=ferro;
        this.plastico=plastico;
        this.ceramica=ceramica;
    }
    public string getNome_Produto(){
        return nome_produto;
    }
    public string getFornecedor(){
        return fornecedor;
    }


}
class Aula40{
    static void Main(){
        int madeira=0,ferro=30,plastico=10,ceramica=0;
        string fornecedor="voce",nome_produto="pc";
        ProdutoFinal produto=new ProdutoFinal(fornecedor,nome_produto,madeira,ferro,plastico,ceramica);
        System.Console.WriteLine("os dados são:\nnome do produto {0}\nquantidade de madeira(kilo) : {1}\nquantidade de ferro(kilo) : {2}\nquantidade de plastico(kilo) : {3}\nquantidade ceramica(kilo) : {4}",nome_produto,produto.madeira,produto.ferro,produto.plastico,produto.ceramica);
    }
}