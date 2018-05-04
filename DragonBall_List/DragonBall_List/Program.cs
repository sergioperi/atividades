using System;
using System.Collections.Generic;

namespace DragonBall_List
{
	class MainClass
	{
		public struct luta{
	        public string nome;
	        public int vida;
	        public int vitorias;

	        public luta(string name, int life, int win){
	                this.nome = name;
	                this.vida = life;
	                this.vitorias = win;
	            }
	    };
        public static void Main (string[] args)
        {
            List<luta> competidores = new List<luta>();
            competidores.Add (new luta ("Goku", 200, 0));
            competidores.Add (new luta ("Vedita", 100, 0));
            competidores.Add (new luta ("Madimbu", 150, 0));
            competidores.Add (new luta ("Mr. Satã", 50, 0));
			luta lutador1;
            luta lutador2;
			int forca1 = 0;
			int forca2 = 0;
			string continua = "s";

            Random rand = new Random();

			int Goku = 0;
			int Vedita = 0;
			int Madimbu = 0;
			int Mr_Sata = 0;



			while(continua == "s")
			{
				lutador1 = competidores[rand.Next(1, 4)];

				lutador2 = competidores[rand.Next(1, 4)];

				while ((lutador1.vida > 0 && lutador2.vida > 0) && lutador1.nome != lutador2.nome) {
					if (lutador1.vida > 0) {
						forca1 = rand.Next (1, 10);
						Console.Write (lutador1.nome + " ataca " + lutador2.nome + "\n");
						Console.Write (lutador1.nome + " bate com força " + forca1 + "\n");
						lutador2.vida -= forca1;
						Console.Write (lutador2.nome + " ainda tem " + lutador2.vida + " de vida\n");
					}
					Console.Write ("===============\n");
					Console.ReadKey ();
					if (lutador2.vida > 0) {
						forca2 = rand.Next (1, 10);
						Console.Write (lutador2.nome + " ataca " + lutador1.nome + "\n");
						Console.Write (lutador2.nome + " bate com força " + forca2 + "\n");
						lutador1.vida -= forca2;
						Console.Write (lutador1.nome + " ainda tem " + lutador1.vida + " de vida\n");
					}
				}

				if (lutador1.vida > 0 && lutador2.vida <= 0) {
					Console.Write ("Parabéns " + lutador1.nome + " você é o vencedor\n");
					if (lutador1.nome == "Goku") {
						Goku += 1;
					}

					else if (lutador1.nome == "Vedita") {
						Vedita += 1;
					}

					else if (lutador1.nome == "Madimbu") {
						Madimbu += 1;
					}

					else if (lutador1.nome == "Mr. Satã") {
						Mr_Sata += 1;
					}
				}
				else if (lutador1.vida <= 0 && lutador2.vida > 0) {
					Console.Write ("Parabéns " + lutador2.nome + " você é o vencedor\n");
					if (lutador2.nome == "Goku") {
						Goku += 1;
					}

					else if (lutador2.nome == "Vedita") {
						Vedita += 1;
					}

					else if (lutador2.nome == "Madimbu") {
						Madimbu += 1;
					}

					else if (lutador2.nome == "Mr. Satã") {
						Mr_Sata += 1;
					}
				}
				Console.Write ("Deseja continuar a batalha? ");
				continua = Console.ReadLine ();
			}



			Console.Write ("Goku " + " tem " + Goku + " Vitórias\n");
			Console.Write ("Vedita " + " tem " + Vedita + " Vitórias\n");
			Console.Write ("Madimbu " + " tem " + Madimbu + " Vitórias\n");
			Console.Write ("Mr. Satã " + " tem " + Mr_Sata + " Vitórias\n");			            
		} 
	}
}
