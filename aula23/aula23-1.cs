using System;

class Aula23{
    static void Main(){
        int[] vetor=new int[10]; 

        Random test=new Random();
        for(int i=0;i<10;i++){
            vetor[i]=test.Next(1,10000000);
            Console.WriteLine("{0}",vetor[i]);

        }
        


    }

}