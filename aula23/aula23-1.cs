using System;

class Aula23{
    static void Main(){
        int[] vetor=new int[10],
        vetor2=new int[10]; 

        Random test=new Random();
        for(int i=0;i<vetor.Length;i++){
            vetor[i]=test.Next(1,10);
            if(i+1 == vetor.Length)
            {
                Console.WriteLine("{0}.",vetor[i]);
            }else
            {
                System.Console.Write("{0}, ",vetor[i]);
            }
        }
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        //o Binarysearch estar no arquivo aula23-2

        //n tive nem uma ideia do que fazer com os copy!

        Array.Copy(vetor,vetor2,vetor.Length);

        for (int i=0;i<vetor2.Length;i++){
            if(i+1 == vetor2.Length){
            Console.WriteLine("{0}.",vetor2[i]);
        }else{
            System.Console.Write("{0}, ",vetor2[i]);
        }
        }
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        //copy to
        vetor.CopyTo(vetor2,0);
        
        for (int i=0;i<vetor2.Length;i++){
            if(i+1 == vetor2.Length){
            Console.WriteLine("{0}.",vetor2[i]);
        }else{
            System.Console.Write("{0}, ",vetor2[i]);
        }
        }




    }

}