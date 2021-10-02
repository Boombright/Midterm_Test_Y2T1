using System;
using System.Collections.Generic;

public class gamesystem
{
	List<String> wordpool = new List<string>();
	List<String> guessword = new List<string>();
	int nopescore;
	public gamesystem()
	{
		wordpool.Add("Tennis");
		wordpool.Add("Football");
		wordpool.Add("Badminton");
		String guessword = "";
		int nopescore = 0;
	}
	public void Startgame()
     {
		Random random = new Random();
		Console.Clear();
		Console.WriteLine("You're now playing Hangman! Enjoy! ;)");
		Console.WriteLine("-----------------------------------");
		Console.WriteLine("incorrect guesses = " + nopescore);
		int resultRandom = random.Next(0, 2);
		for (int i = 0; i < wordpool[resultRandom].Length; i++)
		{
			guessword.Add("_ ");
		}
		for (int i=- 0; i < guessword.Count; i++)
		{
			Console.Write(guessword[i]);
        }
		Console.WriteLine("\nGuess your letters!");
		char guess = ' ';
		bool found = false;
		string final = "";
        while (true)
        {
			guess = Console.ReadKey().KeyChar;
			for (int i = 0; i < wordpool[resultRandom].Length; i++)
			{
				if (guess == wordpool[resultRandom][i])
				{
					guessword[i] = guessword[i].Replace('_', guess);
					found = true;
					final = string.Join("", guessword);
					final = final.Replace(" ","");
				}
			}
			if(found == false)
            {
				nopescore++;
            }
			if(nopescore == 6)
            {
				Console.Clear();
				Console.WriteLine("Game Over!! GGWP");
				Console.ReadLine();
				nopescore = 0;
				break;
            }
			if(final == wordpool[resultRandom])
            {
				Console.Clear();
				Console.WriteLine("You Win!! GG!! Congrat!!");
				Console.ReadLine();
				guessword.Clear();
				break;
            }
			Console.Clear();
			Console.WriteLine("You're now playing Hangman! Enjoy! ;)");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("incorrect guesses = " + nopescore);
			for (int i = 0; i < guessword.Count; i++)
			{
				Console.Write(guessword[i]);
			}
		}
		
	}
}
