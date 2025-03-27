using System;
class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        EternalGoal Getpoints = new EternalGoal();
        Goals goals = new Goals();
        while(true)
        {
            int points = Getpoints.GetPoints();
            int userinput = menu.DeafaultMenu(points);
            if(userinput == 1)
            {
                int moreuserinput = menu.CreateGoalMenu();
                if(moreuserinput == 1)
                {
                    //simple
                    SimpleGoal simpGoal = new SimpleGoal();
                    Console.WriteLine("What is the name of the Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the points for each compleations of this Goal?");
                    int ppc = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the name of the Goal?");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    simpGoal.SetName(name);
                    simpGoal.SetDescription(description);
                    simpGoal.SetPPC(ppc);
                    simpGoal.SetBonus(bonusPoints);
                    goals.AddGoal(simpGoal);
                }
                else if(moreuserinput == 2)
                {
                    //checklist
                    SimpleGoal simpGoal = new SimpleGoal();
                    Console.WriteLine("What is the name of the Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the points for each compleations of this Goal?");
                    int ppc = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the name of this Goal?");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the amount to be done of this Goal?");
                    int atd = int.Parse(Console.ReadLine());
                    simpGoal.SetName(name);
                    simpGoal.SetDescription(description);
                    simpGoal.SetPPC(ppc);
                    simpGoal.SetBonus(bonusPoints);
                    simpGoal.SetATD(atd);
                    goals.AddGoal(simpGoal);
                }
                else if(moreuserinput == 3)
                {
                    //eternal
                    SimpleGoal simpGoal = new SimpleGoal();
                    Console.WriteLine("What is the name of the Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the points for each compleations of this Goal?");
                    int ppc = int.Parse(Console.ReadLine());
                    simpGoal.SetName(name);
                    simpGoal.SetDescription(description);
                    simpGoal.SetPPC(ppc);
                    goals.AddGoal(simpGoal);
                }
            }
            else if(userinput == 2)
            { goals.DisplayGoals(); }
            else if(userinput == 3)
            { goals.SaveGoals(); }
            else if(userinput == 4)
            { goals.Load(); }
            else if(userinput == 5)
            { goals.CompleteAGoal(); }
            else if(userinput == 6)
            { Environment.Exit(0); }
            else
            { Console.WriteLine("Try a different number"); }
















        }

    }
}