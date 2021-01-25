using System;

class Aula24{
    static void Main(){
        int resultado=0;

        System.Console.Write("digite um numero : ");
        int n1=Int32.Parse((Console.ReadLine()));
        System.Console.Write("digite outro numero : ");
        int n2=Convert.ToInt32(Console.ReadLine());


        resultado=soma(n1,n2);
        System.Console.WriteLine("a soma do {0} e {1} e igual á {2}",n1,n2,resultado);
    }
    static int soma(int n1,int n2){
        return n1+n2;

    }
}