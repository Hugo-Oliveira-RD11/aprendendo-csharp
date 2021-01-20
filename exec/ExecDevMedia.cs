//link do execicio https://www.youtube.com/watch?v=IlL7eja1UJA

using System;

class ExecDev{

    static void Main(){
        const int user = 1234,senha=9999;
        int Test_User=0,Test_Senha=0;
        int escolha=0;

        Console.Write("Usuario : ");
        Test_User=int.Parse(Console.ReadLine());

        if(Test_User != user){
            Console.WriteLine("Usuário Inválido");
            Environment.Exit(0);
        }

        do{
        Console.Write("Senha : ");
        Test_Senha=int.Parse(Console.ReadLine());
        
        if(Test_Senha == senha){
            Console.WriteLine("Acesso Permitido");
            Environment.Exit(0);

        }else{
            
            Console.WriteLine("Senha Incorreta");
            Console.Write("1-Tentar de novo\n0-encerrar o sistema\nQual opção vc escolhe : ");
            escolha=int.Parse(Console.ReadLine());
            
            switch(escolha){
                case 1:
                    break;
                case 0:
                    Console.WriteLine("Saiu");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("opção invalida");
                    Environment.Exit(0);
                    break;
            }

        }
        }while(Test_Senha!=senha);
}
}