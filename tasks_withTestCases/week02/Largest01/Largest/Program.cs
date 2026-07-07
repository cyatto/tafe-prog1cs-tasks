// // See https://aka.ms/new-console-template for more information

// Console.WriteLine("Enter value for A: ");
// string? A = Console.ReadLine();
// Console.WriteLine("Enter value for B: ");
// string? B = Console.ReadLine();

// int Adig = int.Parse(A);
// int Bdig = int.Parse(B);

// Console.WriteLine("");
// if(Adig == Bdig) {
//     Console.WriteLine($"{Adig} is the largest but the other value was the same");
// } else if(Adig > Bdig) {
//     Console.WriteLine($"{Adig} is the largest");
// } else {
//     Console.WriteLine($"{Bdig} is the largest");
// }

// My script

// get values of A and B from user
Console.WriteLine("Enter value for A: ");
string input_A = Console.ReadLine();
Console.WriteLine("Enter value for B: ");
string input_B = Console.ReadLine();

// convert strings to numbers
double A = double.Parse(input_A);
double B = double.Parse(input_B);

// conditional logic for comparisons
// if A is greater than B
// else if B is greater than A
// else if A == B
Console.WriteLine("");
if (A > B)
{
    Console.WriteLine($"{A} is the largest");
}
else if (B > A)
{
    Console.WriteLine($"{B} is the largest");
}
else if (A == B)
{
    Console.WriteLine($"{A} is the largest but the other value was the same");
}