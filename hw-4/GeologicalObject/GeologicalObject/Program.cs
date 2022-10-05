using Program;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            GeologicalObject test = new River("Dnipro", 50.0, 34.0, "River in Ukraine", 1.2, 600);
            System.Console.WriteLine(test.GetInfo());
            test = new Mountain("Hoverla", 44.0, 30.0, "Mountain in Ukraine", "Everest");
            System.Console.WriteLine(test.GetInfo());

            System.Console.WriteLine("==============================");
            IGeoObject test2 = new RiverFromI("Dnipro", 1000);
            System.Console.WriteLine(test2.GetInfo());
            test2 = new MountainFromI("Hoverla", 2081);
            System.Console.WriteLine(test2.GetInfo());
        }
    }
}