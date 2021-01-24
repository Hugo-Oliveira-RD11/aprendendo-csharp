using System;

class Aula22{
    static void Main(){
        int[] nums=new int[6]{1,2,3,4,5,6};


        foreach (var i in nums)
        {
            
            if(i+1 == 7){
                System.Console.Write("{0}",i);

            }else
            {
                Console.Write("{0}, ",i);
            }

        }
        

    }

}