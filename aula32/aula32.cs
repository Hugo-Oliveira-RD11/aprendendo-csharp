//nessa aula eu aprendi a usar o this, mas eu não tenho nem uma ideia pra treinar o this
//o this server especificar que a varialvel num1 ( que estar dentro de calculo e de soma ), e outro , por exemplo:
//num1 estar dentro de calculo e de soma, dentro de soma num1, e um parametro de entrada, se eu quiser que o num1 que estar fora vai receber o num1
//que estar dentro de soma,vai dar erro(Warning,não e erro, mas n vai funcionar ), pois o compilador não entendi que eu estou dizendo que o num1 
//e o de fora...


using System;

class Calculo{
    static public int num1;
    static public int num2;

    public soma(int num1,int num2){
        this.num1=num1;
        this.num2=num2;

    }
    
}
class Aula32{
    static void Main(){

    }

}