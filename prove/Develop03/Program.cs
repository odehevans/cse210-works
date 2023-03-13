using System;

class Program
{
  static List<Scripture> _scriptures = new List<Scripture>();
  static Random _random = new Random();
  static void Main(string[] args)
  {
    // Showing Creativity and Exceeding Requirements
    string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
    foreach (string line in lines)
    {
      string[] parts = line.Split("::");
      string text = parts[0];
      string book = parts[1];
      int chapter = int.Parse(parts[2]);
      int verse = int.Parse(parts[3]);

      Reference reference;



      if (parts.Length > 4)
      {
        int endVerse = int.Parse(parts[3]);
        reference = new Reference(book, chapter, verse, endVerse);
      }
      else
      {
        reference = new Reference(book, chapter, verse);
      }

      _scriptures.Add(new Scripture(reference, text));
    }

    int index = _random.Next(_scriptures.Count);
    Scripture scripture = _scriptures[index];

    while (!scripture.AllHidden())
    {
      Console.Clear();

      scripture.Display();

      Console.WriteLine();
      Console.WriteLine("Press enter to continue or type 'quit' to finish:");
      string reply = Console.ReadLine();

      if (!String.IsNullOrEmpty(reply) && reply.ToLower() == "quit") break;

      scripture.hideRandomWord();
      scripture.hideRandomWord();
    }
  }
}