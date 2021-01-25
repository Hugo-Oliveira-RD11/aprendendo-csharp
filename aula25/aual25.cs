using System;

class Aula25{
//aqui aprendi que a gento so passa o valor da variavel, não ela em si, para passar ela tem que usar o ref na função e na chamada da função!


    static void Main(){

 
        int nuum=5;
        soma2(ref nuum);
        System.Console.WriteLine(nuum);

    }
    static void soma2(ref int num){
        num+=2;
    }

}