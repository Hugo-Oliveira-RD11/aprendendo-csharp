//projeto failed
//descobrir que tem que usar o sort antes do binarysearch
using System;

class Aula23{
    static void Main(){
        int[] produtos=new int[5];
        int escolha=0,Test_escolha=-1;
        
        Random doido=new Random();
        
        for(int i=0;i<produtos.Length;i++){
            produtos[i]=doido.Next(1,10);
        }
        System.Console.Write("TESTE A SUA SORTE!\n\ndigite um numero : ");
        escolha=int.Parse(Console.ReadLine());

        Test_escolha=Array.BinarySearch(produtos,escolha);
        System.Console.WriteLine("resultado {0}",Test_escolha+1);        
        
        foreach(var mostra in produtos){
            System.Console.WriteLine(mostra);

        }


        

        


    }

}