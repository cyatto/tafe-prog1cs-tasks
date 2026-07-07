namespace _03AreaOfATriangle;

class Program
{
    static void Main(string[] args)
    {
        // arguments: base, height
        // area = base * height
        // output area to two decimal places
        // example: dotnet run 5 37.50

        // map input args
        string input_base = args[0];
        string input_height = args[1];

        // convert strings to numbers
        double triangleBase = double.Parse(input_base);
        double triangleHeight = double.Parse(input_height);

        // calculate area
        double area = triangleBase * triangleHeight;

        // output to 2 decimal places --> value.ToString("F2");
        Console.WriteLine("Area of triangle: " + area.ToString("F2") + " m squared");
    }
}
