namespace Converter
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(40, 42);
            System.Console.WriteLine("Enter UAH: ");
            decimal temp;
            Decimal.TryParse(System.Console.ReadLine(), out temp);
            System.Console.WriteLine("In USD: ");
            System.Console.WriteLine(converter.ConvertUahToUsd(temp));

            System.Console.WriteLine("Enter USD: ");
            Decimal.TryParse(System.Console.ReadLine(), out temp);
            System.Console.WriteLine("In UAH: ");
            System.Console.WriteLine(converter.ConvertUsdToUah(temp));
        }
    }
}