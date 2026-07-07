namespace _01EvenOrOdd;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number greater than 0: ");
        string input = Console.ReadLine();
        double num = Convert.ToInt32(input);

        while (num >= 2)
        {
            num -= 2;
        }

        if (num == 1)
        {
            Console.WriteLine("odd");
        }
        else if (num == 0)
        {
            Console.WriteLine("even");
        }
        else if (num < 0)
        {
            Console.WriteLine("No negatives allowed!");
        }
    }
}
