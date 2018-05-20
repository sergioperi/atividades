using System;

namespace abc
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int unicode = 65;

            for (int i = 1; i <= 26; i++)
	            {

	                char character = (char) unicode;
	                string text = character.ToString();
	                Console.WriteLine(String.Format("{0} - {1}",i,text));
	                unicode ++;
	            }

            Console.ReadKey(); 
		}
	}
}
