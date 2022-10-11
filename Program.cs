using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVotacao
{
    internal class Program
    {
        private static int voto;

        static void Main(string[] args)
        {

            int votosJose = 0;
            int votosMaria = 0;
            int votosNulos = 0;
            int votosBrancos = 0;
            
            Console.WriteLine("-------------ELEIÇOES 2022-------------");
            Console.WriteLine(" ");
            Console.WriteLine("Por favor, informe quantas pessoas irão votar: ");

            int quantEleitores = int.Parse(Console.ReadLine());
            Console.Clear();

            int i = 0;
            while (i < quantEleitores)
            {
                Console.WriteLine("-------ELEIÇOES 2022-------");
                Console.WriteLine(" ");
                Console.WriteLine("Em quem você deseja votar?");
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Para votar em Jose, digite 1");
                Console.WriteLine("Para votar em Maria, digite 2");
                Console.WriteLine(" ");
                Console.WriteLine("Para votar em BRANCO, digite 3");
                Console.WriteLine("Para votar NULO, digite qualquer outro número");

                int voto = int.Parse(Console.ReadLine());

                Console.Clear();
            

                if (voto == 1)
                {
                    votosJose++;
                    Console.WriteLine("Voce votou em JOSÉ!");
                }
                else if(voto == 2)
                {
                    votosMaria++;
                    Console.WriteLine("Voce votou em MARIA!");
                }
                else if(voto == 3)
                {
                    votosBrancos++;
                    Console.WriteLine("Voce votou em BRANCO!");
                }
                else { 
                    votosNulos++;
                    Console.WriteLine("Voce votou NULO!");
                }
             
             i++;
                //Console.WriteLine("Aperte ENTER para continuar!");

                Console.ReadLine();
                Console.Clear();

            }
            
            float votosValidos = quantEleitores - (votosNulos + votosBrancos);

            Console.WriteLine($"José teve: {Math.Round(votosJose * 100 / votosValidos, 2)}% dos Votos Válidos");
            Console.WriteLine($"Quantidade de votos de José: {votosJose}.");
            Console.WriteLine(" ");
            Console.WriteLine($"Maria teve: {Math.Round(votosMaria * 100 / votosValidos, 2)}% dos Votos Válidos");
            Console.WriteLine($"Quantidade de votos de Maria: {votosMaria}.");
            Console.WriteLine(" ");
            Console.WriteLine($"Quantidade de votos Nulos: {votosNulos}.");
            Console.WriteLine(" ");
            Console.WriteLine($"Quantidade de votos Brancos: {votosBrancos}.");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------");


            if (votosJose > votosMaria)
            {
                Console.WriteLine("José venceu a eleição!");
            }
            else if (votosMaria > votosJose)
            {
                Console.WriteLine("Maria venceu a eleição!");
            }
            else
            {
                Console.WriteLine("A eleição terminou empatada!");
            }

            Console.ReadLine();
        }
    }
}
