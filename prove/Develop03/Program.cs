using System;

class Program
{
    static void Main(string[] args)
    {   string text = "Trust in the Lord With all thine heart and lean not unto thine understanding; in all things aknowledge Him and He will direct thy path.";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, text);

        while(!scripture.AllHidden()) {
            Console.Clear();

            scripture.Display();

            Console.WriteLine();
            Console.WriteLine("Press enter to randomly hide words or quit to exit ");
            string reply = Console.ReadLine();

            if (!String.IsNullOrEmpty(reply) && reply.ToLower() == "quit") break;

            scripture.hideRandomWord();
            scripture.hideRandomWord();
        }
    }
}