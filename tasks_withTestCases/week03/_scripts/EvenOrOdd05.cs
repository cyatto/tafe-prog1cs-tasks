var input = Console.ReadLine();
int number = Convert.ToInt32(input);

// Create loop that checks whether conditional expression evaluates to (less than 3)
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

// TODO
// for loop ?
// for (int number = Convert.ToInt32(input); number >= 2; number -= 2)
// {
//     if (number == 0)
//     {
//         Console.WriteLine("Even");
//     }
//     else
//     {
//         Console.WriteLine("Odd");
//     }
// }