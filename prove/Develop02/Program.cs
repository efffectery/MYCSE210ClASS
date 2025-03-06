using System;

//Main or top class
class Program
{
    //Main method
    static void Main(string[] args)
    {
        //Declaring Objects for Use
        MakeEntries prompt = new MakeEntries();
        DisplayCurrentJournalSession displayJournal = new DisplayCurrentJournalSession();
        Save saveToFile = new Save();
        Load loadFile = new Load();
        Menu loadMenu = new Menu();

        //Introduce the program to the user
        Console.WriteLine("Welcome to the Journal Program!\n");

        /*
        Go through the program allowing user to see the menu choose a item on the menu
        And then write to the session Journal || display session Journal || Save session to file ||
        Read Previous Session to file || then exiting if choses or given incorrect input
        */
        while (true)
        {
            loadMenu.ShowMenu();
            string userchoice = Console.ReadLine();

            if (userchoice == "1")
            {
                prompt.AddEntryToJournal();
            }
            else if (userchoice == "2")
            {
                displayJournal.DisplayJournalEntries();
            }
            else if (userchoice == "3")
            {
                saveToFile.SaveToFile();
            }
            else if (userchoice == "4")
            {
                loadFile.ReadFromFile();
            }
            else
            {
                Console.WriteLine("The Program has exited!\n*If you did not want to exit you might have chose a menu item out of scope*");
                System.Environment.Exit(1);
            }

        }
    }
}
