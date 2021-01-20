using System;

class Aula19{
    static void Main(){
        int[] nums=new int[10];
        
        for(int i=0,cont=20;i<cont;i++){
            
            if(i<10 && i>-1){
                nums[i]=i;

                Console.WriteLine("na posição {0} tem o numero {1}",i,nums[i]);
            }
            Console.WriteLine("test");
        }
    }

}