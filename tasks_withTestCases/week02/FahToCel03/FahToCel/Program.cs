// // See https://aka.ms/new-console-template for more information

// string[] cmdargs = args;

// int fah = int.Parse(args[0]);
// int C = (int) ((fah - 32.0) * (5.0/9.0));

// Console.WriteLine(C);


// MY SCRIPT

// accepts one cmd arg --> value in fah
// formula: C = (F - 32) * (5/9)

string[] cmdargs = args;
string inputValF = args[0];

double valF = double.Parse(inputValF);

double valC = (valF - 32.0) * (5.0 / 9.0);

Console.WriteLine(valC);