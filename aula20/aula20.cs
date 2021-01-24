using System;

class Aula20{
    static void Main(){
        int[] num=new int[20];
        int i=0;
        while(i<15){
            num[i]=i;
            Console.WriteLine("na posição {0} tem o numero {1}",i,num[i]);
            
            i++;
        }

        while(i<20){
            num[i]=i;

            Console.WriteLine("na posição {0} tem o numero {1}",i,num[i]);
            i++;
            

        }
    
    }  

}