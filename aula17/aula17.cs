using System;

class Aula17{
    static void Main(){

        int controle;
        int[] n=new int[5];
        n[0]=111;
        n[1]=222;
        n[2]=333;
        n[3]=444;
        n[4]=555;

        Console.Write("escolha um numero de 0 a 4 : ");
        controle=int.Parse(Console.ReadLine());

        switch(controle){
            case -1:
                Console.WriteLine("tchau");
                break;

            case 0:
                Console.WriteLine(n[0]);
                break;

            case 1:
                Console.WriteLine(n[1]);
                break;
            
            case 2:
                Console.WriteLine(n[2]);
                break;
            
            case 3:
                Console.WriteLine(n[3]);
                break;
            
            case 4:
                Console.WriteLine(n[4]);
                break;
            
            default:
                Console.WriteLine("erro, isto não tava na escolha...\n vc faz escolhas pessimas,rs rs");
                break;
        }

        
    }

}