// read mark from input
// output grade that the mark corresponds to

// mark >= 85 => A
// mark >= 75 => B
// mark >= 65 => C
// mark >= 50 => D
// mark < 50  => F

Console.WriteLine("Enter your mark: ");
string inputMark = Console.ReadLine();

// convert string to int
int mark = int.Parse(inputMark);

// conditional logic
if (mark >= 85)
{
    Console.WriteLine("A");
}
else if (mark >= 75)
{
    Console.WriteLine("B");
}
else if (mark >= 65)
{
    Console.WriteLine("C");
}
else if (mark >= 50)
{
    Console.WriteLine("D");
}
else if (mark < 50)
{
    Console.WriteLine("F");
}