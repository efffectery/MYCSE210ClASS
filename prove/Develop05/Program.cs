using System;
class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        Goals goals = new Goals();
        int points = 0;
        while(true)
        {
            int userinput = menu.DeafaultMenu(points);
            if(userinput == 1)
            {
                int moreuserinput = menu.CreateGoalMenu();
                if(moreuserinput == 1)
                {
                    //simple
                    EternalGoal eternalGoal = new EternalGoal();
                    Console.WriteLine("What is the name of the Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the points for each compleations of this Goal?");
                    int ppc = int.Parse(Console.ReadLine());
                    eternalGoal.SetName(name);
                    eternalGoal.SetType("EternalGoal");
                    eternalGoal.SetDescription(description);
                    eternalGoal.SetPPC(ppc);
                    goals.AddGoal(eternalGoal);
                }
                else if(moreuserinput == 2)
                {
                    //checklist
                    ChecklistGoal CheckGoal = new ChecklistGoal();
                    Console.WriteLine("What is the name of the Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the points for each compleations of this Goal?");
                    int ppc = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus points of this Goal?");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the amount to be done of this Goal?");
                    int atd = int.Parse(Console.ReadLine());
                    CheckGoal.SetType("ChecklistGoal");
                    CheckGoal.SetName(name);
                    CheckGoal.SetDescription(description);
                    CheckGoal.SetPPC(ppc);
                    CheckGoal.SetBonus(bonusPoints);
                    CheckGoal.SetATD(atd);
                    CheckGoal.SetAD(0);
                    goals.AddGoal(CheckGoal);
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
                    simpGoal.SetType("SimpleGoal");
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
            { 
                goals.Load(); 
                points = goals.GetPointsFromGoals();
            }
            else if(userinput == 5)
            { 
                points = goals.CompleteAGoal(); 
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
                Console.WriteLine("+_+_+_+_+_+__+_++_+_+_+_+_+_+_YOU COMPLETED A GOAL!!!!+++__+_+_+_+__++_+_+_+_+_");
            }
            else if(userinput == 6)
            { Environment.Exit(0); }
            else
            { Console.WriteLine("Try a different number"); }
















        }

    }
}