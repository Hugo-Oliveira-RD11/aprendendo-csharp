using System;

class Aula8{
    static void Main(){
        int num1,num2;
        
        Console.WriteLine("----------CALCULADORA----------");
        Console.Write("digite um numero : ");
        num1=Convert.ToInt32(Console.ReadLine());

        Console.Write("digite outro um numero : ");
        num2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("a soma de {0} e {1} e igual a {2}",num1,num2,num1+num2);
        Console.WriteLine("a subtração de {0} e {1} e igual a {2}",num1,num2,num1-num2);
        Console.WriteLine("a multiplicação de {0} e {1} e igual a {2}",num1,num2,num1*num2);
        Console.WriteLine("a divisão de {0} e {1} e igual a {2}",num1,num2,num1/num2);
        Console.WriteLine("o resto de {0} e {1} e igual a {2}",num1,num2,num1%num2);
    }

}