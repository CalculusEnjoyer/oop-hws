class Hello
{
    static void Main(string[] args)
    {
        int n;
        System.Console.Write("Enter number: ");
        if(!int.TryParse(System.Console.ReadLine(), out n)) throw new ArgumentException("Enter number");
        System.Console.WriteLine("Your number: " + n);
    }
}