using System;

namespace Ordenacao
{
	class MainClass
	{
		static int[] y = {2,1,4,5,40,3,7,78,58,28};
		public static void Main (string[] args)
		{
//			Array.Sort (y);
//			foreach(int item in y){
//				Console.Write (item + " ");
//			}
			bubblesort(y);
			foreach (int s in y) {
				Console.Write (s + " ");
			}
		}

		public static void bubblesort(int[] y){
	        for (int i = 1; i < y.Length; i++)
		            for (int j = 0; j < y.Length - 1; j++)
			                if (y [j] > y [j + 1])
				                    troca (y, j);             
	    }

	    public static void troca(int[] g, int primeiro){
	        int aux;
	        aux = g [primeiro];
	        g[primeiro] = g[primeiro + 1];
	        g[primeiro + 1] = aux;
	    }  
	}
}
