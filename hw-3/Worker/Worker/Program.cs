namespace Worker
{
    class Program
    {
        static void Main(string[] args)

        {
            System.Console.WriteLine("=======================");
            new Developer("Andriy").FillWorkDay();
            System.Console.WriteLine("=======================");
            new Manager("Bogdan").FillWorkDay();
            System.Console.WriteLine("=======================");

            System.Console.WriteLine("Enter team name");
            Team team = new(Console.ReadLine());

            System.Console.WriteLine("Adding developer...");
            System.Console.Out.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            System.Console.Out.WriteLine("Enter work day: ");
            string workDay = Console.ReadLine();

            Developer newDev = new Developer(name);
            newDev.SetWorkDay(workDay);
            team.AddWorker(newDev);
            
            System.Console.WriteLine("Adding manager...");
            System.Console.Out.WriteLine("Enter name: ");
            name = Console.ReadLine();
            System.Console.Out.WriteLine("Enter work day: ");
            workDay = Console.ReadLine();

            Manager newMan = new(name);
            newMan.SetWorkDay(workDay);


            team.AddWorker(newMan);

            System.Console.WriteLine("=======================");
            team.ShowWorkersNames();
            System.Console.WriteLine("=======================");
            team.ShowWorkersFull();
        }
    }
}