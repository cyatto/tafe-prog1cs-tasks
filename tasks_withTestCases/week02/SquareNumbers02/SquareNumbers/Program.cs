// // See https://aka.ms/new-console-template for more information
// string[] cmdargs = args;

// int v = int.Parse(cmdargs[0]);

// Console.WriteLine(v * v);


// MY SCRIPT //

// output the square of the number
// value provided as command line argument
// convert the command line arg to an integer and multiply it by itself

string[] cmdargs = args;

// map command line arg to arg[0]
string input_int = args[0];

// convert to int
int intValue = int.Parse(input_int);

// calculation: square = int * int
int square = intValue * intValue;

// output
Console.WriteLine(square);