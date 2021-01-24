using System;

class Aula23{
    static void Main(){
        int[] vetor=new int[10],
        vetor2=new int[10]; 
        int returno1=0,random=0;

        Random test=new Random();
        Random test2=new Random();
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

        //session copys
        System.Console.WriteLine("Array.Copy");
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
        System.Console.WriteLine("CopyTo!");
        
        vetor.CopyTo(vetor2,0);
        
        for (int i=0;i<vetor2.Length;i++){
            if(i+1 == vetor2.Length){
            Console.WriteLine("{0}.",vetor2[i]);
        }else{
            System.Console.Write("{0}, ",vetor2[i]);
        }
        }   
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("GetValue");
        returno1=Convert.ToInt32(vetor.GetValue(5));
        System.Console.WriteLine(returno1);

        returno1=0;
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("indexOf");
        returno1=Array.IndexOf(vetor,random=test2.Next(1,10));
        System.Console.WriteLine("numero pesquisado {0},resultado {1}",random,returno1);

        returno1=0;
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("LastIndexOf");
        returno1=Array.LastIndexOf(vetor,random);
        System.Console.WriteLine("numero pesquisado {0},resultado {1}",random,returno1);


        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("Reverse!");

        Array.Reverse(vetor);
        for(int i=0;i<vetor.Length;i++){
            if(i+1 == vetor.Length)
            {
                Console.WriteLine("{0}.",vetor[i]);
            }else
            {
                System.Console.Write("{0}, ",vetor[i]);
            }
        }
        
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("SetValue");
        vetor2.SetValue(11,0);

        for (int i=0;i<vetor2.Length;i++){
            if(i+1 == vetor2.Length){
            Console.WriteLine("{0}.",vetor2[i]);
        }else{
            System.Console.Write("{0}, ",vetor2[i]);
        }
        }

        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("Sort!");
        Array.Sort(vetor);
        Array.Sort(vetor2);
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("vetor 1 :");
        for (int i=0;i<vetor.Length;i++){
            if(i+1 == vetor.Length){
            Console.WriteLine("{0}.",vetor[i]);
        }else{
            System.Console.Write("{0}, ",vetor[i]);
        }
        }
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine("vetor2 : ");

        for (int i=0;i<vetor2.Length;i++){
            if(i+1 == vetor2.Length){
            Console.WriteLine("{0}.",vetor2[i]);
        }else{
            System.Console.Write("{0}, ",vetor2[i]);
        }
        }





    }

}