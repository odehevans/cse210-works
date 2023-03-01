using System;
// Exceed requirements by using try-catch to handle file not found error in the Journal.LoadEntries method.
// Exceed requirements in menu by adding a default option that display a message if a wrong choice was entered.
class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    journal.Menu();
  }
}