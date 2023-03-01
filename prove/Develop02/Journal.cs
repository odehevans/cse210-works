public class Journal
{
  public List<Entry> _entries = new List<Entry>();


  public void AddEntry()
  {
    string prompt = PromptGenerator.GetRandomPrompt();
    Console.WriteLine(prompt);
    string promptAnswer = Console.ReadLine();

    DateTime theCurrentTime = DateTime.Now;

    Entry entry = new Entry();
    entry._prompt = prompt;
    entry._response = promptAnswer;
    entry._date = theCurrentTime.ToShortDateString();
    _entries.Add(entry);
    Console.WriteLine();
  }

  public void DisplayEntries()
  {
    Console.WriteLine();
    foreach (Entry entry in _entries)
    {
      entry.Display();
      Console.WriteLine();
    }
  }

  public void SaveEntries()
  {
    Console.WriteLine("What is the filename? ");
    using (StreamWriter outputFile = new StreamWriter(Console.ReadLine()))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._prompt}:{entry._response}:{entry._date}");
      }
    }
    Console.WriteLine();
  }

  public void LoadEntries()
  {
    Console.WriteLine("What is the filename? ");

    try
    {
      string[] lines = System.IO.File.ReadAllLines(Console.ReadLine());
      foreach (string line in lines)
      {
        string[] parts = line.Split(":");
        Entry entry = new Entry();
        entry._prompt = parts[0];
        entry._response = parts[1];
        entry._date = parts[2];
        _entries.Add(entry);
      }
    }
    catch (FileNotFoundException e)
    {
      Console.WriteLine("An error occured: {0}", e.Message);
    }
    catch (Exception e)
    {
      Console.WriteLine("An error occurred during operation.");
    }

    Console.WriteLine();
  }

  public void Menu()
  {
    List<string> choices = new List<string>() { "Write", "Display", "Load", "Save", "Quit" };
    Console.WriteLine("Welcome to the journal program!");
    Console.WriteLine();

    bool quit = false;

    while (!quit)
    {
      Console.WriteLine("Please select one of the following choices!");

      int index = 1;
      foreach (string choice in choices)
      {
        Console.WriteLine($"{index}. {choice}");
        index++;
      }

      Console.Write("What would you like to do? ");
      string menuChoice = Console.ReadLine();

      switch (menuChoice)
      {
        case "1":
          AddEntry();
          break;
        case "2":
          DisplayEntries();
          break;
        case "3":
          LoadEntries();
          break;
        case "4":
          SaveEntries();
          break;
        case "5":
          quit = true;
          Console.WriteLine("QUIT!");
          break;
        default: // If user didn't select a valid option display message and allow try again.
          Console.WriteLine($"You have not entered a valid option. Enter a value from 1 to 5");
          break;
      }

      Console.WriteLine();
    }
  }
}