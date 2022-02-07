using System;
using System.Threading; //biblioteca para o 

namespace cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo ==> 10s = 10 segundos");
            Console.WriteLine("M = Minuto ==> 10m = 10 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Qual tempo deseja contar?");
            //
            string data = Console.ReadLine().ToLower();          
            if (data == "0")
                System.Environment.Exit(0);

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            // Substring pega o ultimo caracter, que vai ser o tipo contado
            //Substring(indice p começar a contar, quantos caracteres serao pegos)
            int time = int.Parse(data.Substring(0, data.Length - 1)); //tempo até finalizar a contagem;

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;// para converter minutos em segundos, simplificando o processo;
            }

            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set..");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;//contará até chegar no time
            Console.WriteLine("0");
            Thread.Sleep(1000);//apos 1000 milissegundos imprimira na tela;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            //
            Console.Clear();
            Console.WriteLine("Temporizador finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
