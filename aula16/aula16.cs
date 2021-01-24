using System;

class Aula16{

    static void Main(){

        inicio:
        Console.Clear();
        
        int esc=0,tempo=0;
        string esc2="";
        Console.WriteLine("viagem de brasilia(BR) ate são paulo(SP)");
        Console.WriteLine("formas de viagem :\n[ 1 ]ONIBUS\n[ 2 ]AVIÃO\n[ 3 ]CARRO");
        Console.Write("qual opção vc escolhe : ");
        esc=Convert.ToInt32(Console.ReadLine());


            switch(esc){
                case 1:
                    tempo=60;
                    Console.WriteLine("a viagem de onibus dura {0} \npor ter quer parar pra outros passageiros, mas vc não precisa se preocupar com a viagem",tempo);
                    break;

                case 2:
                    tempo=7;
                    Console.WriteLine("a viagem de avião dura {0} \ne mais cara, mas chega bem mais rapido",tempo);
                    break;

                case 3:
                    tempo=40;
                    Console.WriteLine("a viagem de carro dura {0} \na viagem de carro e mais dificil pois e vc que dirige, mas vc não paga nada!(so a gasolina)",tempo);
                    break;
                default:
                    tempo=-1;
                    Console.WriteLine("bom, essa opção não exite!, reinicie o programa!");
                    break;
            }
            Console.Write("obrigado por escolher o nosso produto!\ntenha uma boa viagem! \n\nvc quer reiniciar o programa ? [S/n]");
            
            esc2=Console.ReadLine();

            switch(esc2){
                case "s":
                case "S":
                    goto inicio;
                
                default:
                    Console.WriteLine("tchau");
                    break;

            }       
            
        
    }

}