namespace EvenOrOdd;

class Program
{
    static void Main(string[] args)
    {
        string input = args[0];

        // Convert input string to integer
        int number = Convert.ToInt32(input);

        // Create loop that checks whether conditional expression evaluates to (less than 3)
        // then check if value is either 0 or 1
        // IF 0 --> EVEN, ELSE --> ODD

        // while loop

        // Create loop that checks whether conditional expression evaluates to (less than 3)
        // Exit loop when evaluates to false
        // Outside of loop:
        // then check if value is either 0 or 1
        // IF 0 --> EVEN, ELSE --> ODD

        // while loop
        while (number >= 2)
        {
            // decrement by 2 after if/else statement
            number -= 2;
        }

        // Once out of loop, if/else statement

        if (number == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}
