namespace _03NumberRanges;

class Program
{
    static void Main(string[] args)
    {
        // map input args
        string input_start = args[0];
        string input_end = args[1];
        string input_step = args[2];

        // convert to numbers
        int start = Convert.ToInt32(input_start);
        int end = Convert.ToInt32(input_end);
        int step = Convert.ToInt32(input_step);

        while (start <= end)
        {
            Console.WriteLine(start);
            start += step;
        }
    }
}
