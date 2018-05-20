using System;

namespace vinteum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int carta = 0;
			int jogador = 0;
			int mesa = 0;
			int nr_as = 0;
			string continuar;

			Console.Write ("Vamor jogar? s/n \n");
			continuar = Console.ReadLine ();
			Random rand = new Random ();

			while(continuar == "s")
			{
				carta = rand.Next (1, 13);
				Console.Write ("O jogador pediu a carta " + carta + "\n");
				if (carta == 1) {
					carta = 11;
					nr_as += 1;
				}
				jogador += carta;

				if(nr_as > 0 && jogador > 22)
				{
					jogador -= 10;
				}


				Console.Write ("O jogador tem " + jogador + " pontos \n");

				if(jogador < 22)
				{
					Console.Write ("Deseja continuar? s/n - ");
					continuar = Console.ReadLine ();
				}

				else if(jogador > 21){
					Console.Write ("Lamento, você estourou sua pontuação\n");
					continuar = "n";
				}
			}

			Console.Write ("O jogador terminou com " + jogador + " pontos\n");
			Console.Write ("-------------------Agora é a vez da mesa--------------\n");

			continuar = "s";

			while(continuar == "s")
			{
				carta = rand.Next (1, 13);
				Console.Write ("O mesa pediu a carta " + carta + "\n");
				if (carta == 1) {
					carta = 11;
					nr_as += 1;
				}
				mesa += carta;

				if(nr_as > 0 && jogador > 22)
				{
					mesa -= 10;
				}


				Console.Write ("O mesa tem " + mesa + " pontos \n");

				if(mesa < jogador)
				{
					
					continuar = "s";
				}

				else if(mesa > 21 && jogador > 21){
					Console.Write ("Opa! Deu empate!\n");
					continuar = "n";
				}
				else if(mesa > 21 && jogador < 22){
					Console.Write ("Parabéns, Você venceu!\n");
					continuar = "n";
				}

			}

			
		}
	}
}
