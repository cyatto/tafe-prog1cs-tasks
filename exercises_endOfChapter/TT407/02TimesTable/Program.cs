namespace _02TimesTable;

class Program
{
    static void Main(string[] args)
    {
        // while loop
        
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();
        double number = Convert.ToInt32(input);
        int counter = 1;

        while (counter <= 12)
        {
            Console.WriteLine($"{number * counter}");
            counter += 1;
        }

        // for loop
        // for (int counter = 1; counter <= 12; counter++)
        // {
        //     Console.WriteLine($"{number * counter}");
        // }
    }
}
