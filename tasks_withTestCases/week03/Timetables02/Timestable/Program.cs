// string[] cmdargs = Environment.GetCommandLineArgs();

// int v = int.Parse(cmdargs[0]);

// for(int i = 1; i <= 12; i++) {
//     Console.WriteLine(v * i);
// }

// As C# Statements
Console.WriteLine("Enter Number: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

for (int multiplier = 1; multiplier <= 12; multiplier++)
{
    Console.WriteLine(number * multiplier);
}