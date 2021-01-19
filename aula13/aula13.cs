using System;


class Aula13{
    static void Main(){
        int n1,n2,n3,n4,media;
        
        System.Console.Write("nota do 1° bimstre ? ");
        n1=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("nota do 2° bimestre ? ");
        n2=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("nota do 3° bimestre ? ");
        n3=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("nota do 4° bimestre ? ");
        n4=Convert.ToInt32(Console.ReadLine());

        media = n1+n2+n3+n4;

        if (media >= 60){
            System.Console.WriteLine("a media e de {0}\no aluno(a) estar aprovado",media);
        
        }else if(59 >= media & 40 <= media){
            System.Console.WriteLine("a media e de {0}\no aluno(a) esta de recuperação",media);

        }else
        {
            System.Console.WriteLine("a media e de {0}\no aluno(a) estar reprovado",media);
        };
    }
}