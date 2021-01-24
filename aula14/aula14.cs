using System;

class Aula14{
    static void Main(){
        int n1,n2,n3,n4,media;
        string resultado="";


        System.Console.Write("nota do 1° bimstre ? ");
        n1=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("nota do 2° bimestre ? ");
        n2=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("nota do 3° bimestre ? ");
        n3=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("nota do 4° bimestre ? ");
        n4=Convert.ToInt32(Console.ReadLine());

        media = n1+n2+n3+n4;

        if(media >= 60 && media <= 100){
            if(media >= 90){
                resultado="aprovado com louvor";

            }else{
                resultado="aprovado";
            }

        }else{
            if(media <= 59 && media >= 50){
                resultado="recuperação";

            }else{
                resultado="reprovado";

            }

        }

        Console.WriteLine("media : {0}\nresultado : {1}",media,resultado);
    
    }

}