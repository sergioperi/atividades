using System;
using System.Collections.Generic;

namespace DragonBall
{
	class MainClass
	{
		public struct luta{
			public string nome;
			public int vida;
			public int vitorias;
		};
		public static void Main (string[] args)
		{
			string[] nomes = new string[4];
			nomes [0] = "Goku";
			nomes [1] = "Vedita";
			nomes [2] = "Madimbu";
			nomes [3] = "Mr. Satã";

			Random rand = new Random ();
			luta lutador1;
			luta lutador2;
			int jogador1 = rand.Next (0, 4);
			int jogador2 = rand.Next (0, 4);
			lutador1.nome = nomes [jogador1];
			lutador1.vida = rand.Next (0,400);
			lutador2.nome = nomes [jogador2];
			lutador2.vida = rand.Next (0,400);

			while(lutador1.vida > 0 && lutador2.vida > 0){
				if (lutador1.vida > 0) {
					
					Console.Write (lutador1.nome + " bate em " + lutador2.nome + "\n");
					int forca = rand.Next (1, 5);
					lutador2.vida = lutador2.vida - forca;
					Console.Write (lutador1.nome + " Atacou com força " + forca + "\n");
					Console.Write (lutador2.nome + " ainda tem " + lutador2.vida + " força de vida" + "\n");
				}
				Console.Write ("------------||--------" + "\n");
				if (lutador2.vida > 0) {
					
					Console.Write (lutador2.nome + " bate em " + lutador1.nome + "\n");
					int forca2 = rand.Next (1, 5);
					lutador1.vida = lutador1.vida - forca2;
					Console.Write (lutador2.nome + " Atacou com força " + forca2 + "\n");
					Console.Write (lutador1.nome + " ainda tem " + lutador1.vida + " força de vida" + "\n");
				}
				Console.ReadKey ();
			}
			if(lutador1.vida <= 0){
				Console.Write(lutador2.nome + " Venceu" + "\n");
			}
			else if(lutador2.vida <= 0){
				Console.Write(lutador1.nome + " Venceu" + "\n");
			}

		}
	}
}
