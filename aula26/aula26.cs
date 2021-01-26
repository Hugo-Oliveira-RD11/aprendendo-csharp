using System;

class Aula26{


    static void Main(){
        int num1=5,num2=5,argumento;
        
        
        soma2(num1,num2,out argumento);
        Console.WriteLine("a soma de {0} e {1} e igual a {2}",num1,num2,argumento);
    }
    static void soma2(int n1, int n2,out int n3){
        n3=n1+n2;        
        System.Console.WriteLine("teste");
    }

}