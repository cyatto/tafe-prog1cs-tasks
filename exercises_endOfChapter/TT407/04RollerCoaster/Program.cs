namespace _04RollerCoaster;

class Program
{
    static void Main(string[] args)
    {
        static bool CheckHeight(int height, int threshold)
        {
            return height >= threshold;
        }

        // public const int Threshold = 160;

        bool doesPaulPass = CheckHeight(180, 160);
        Console.WriteLine(doesPaulPass);

        bool doesAlicePass = CheckHeight(160, 160);
        Console.WriteLine(doesAlicePass);

        bool doesJeffPass = CheckHeight(150, 160);
        Console.WriteLine(doesJeffPass);
    }
}
