namespace _01HelloCommandLine;

class Program
{
    static void Main(string[] args)
    {
        // accepts a single command line argument
        // prefix "Hello " to the command line argument

        // args[0] refers to the element at the 0th position of the args array
        string name = args[0];

        // append "Hello " to the output
        Console.WriteLine("Hello " + name);
    }
}
