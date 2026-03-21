using System;
using System.Collections.Generic;

// Added a list to hold multiple scriptures and randomly select one at the start of the program

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        scriptures.Add(new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
        scriptures.Add(new Scripture(new Reference("Matthew", 11, 28, 30), "28: Come unto me, all ye that labour and are heavy laden, and I will give you rest. 29:Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. 30 For my yoke is easy, and my burden is light."));

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }
    }
}