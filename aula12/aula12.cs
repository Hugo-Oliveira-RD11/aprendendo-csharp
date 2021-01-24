using System;


class Aula12{
    static void Main(){
        int n1,n2,n3,n4,media;
        string nome;

        System.Console.Write("qual e o nome do aluno ? ");
        //nome=Convert.ToString(Console.ReadLine());
        nome=(string)Console.ReadLine();

        
        System.Console.Write("quanto o {0} tirou de nota no 1° bimstre ? ",nome);
        n1=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("quanto o {0} tirou de nota no 2° bimestre ? ",nome);
        n2=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("quanto o {0} tirou de nota no 3° bimestre ? ",nome);
        n3=Convert.ToInt32(Console.ReadLine());
        
        System.Console.Write("quanto o {0} tirou de nota no 4° bimestre ? ",nome);
        n4=Convert.ToInt32(Console.ReadLine());

        media =(n1+n2+n3+n4)/4;

        if (media >= 6){
            System.Console.WriteLine("a media e de {0}\n{1} estar aprovado",media,nome);
        }else
        {
            System.Console.WriteLine("a media e de {0}\n{1} estar reprovado",media,nome);
        };
    }
}