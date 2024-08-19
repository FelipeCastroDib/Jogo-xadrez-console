using System;
using Tabuleiro;



namespace xadrez_console 
{
	class Program
	{
		static void Main(string[] args) 
		{
			Posicao P;

			P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

			Console.ReadLine();
        }
	}

}