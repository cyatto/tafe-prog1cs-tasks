using System;

// loop for getting input from user
// exit look when user enters nothing or an EOF signal is sent
// EOF signal --> like null?

bool keepRunning = true;

// create empty List (use below syntax when not knowing the size of final collection)
// var --> implicit declaration
var listOfNumbers = new List<int>();

while (true)
{
    Console.Write("Enter a number: ");
    string? input = Console.ReadLine();
    Console.WriteLine(input);

    if (input == "\n")
    {
        break;
    }
    else if (!int.TryParse(input, out int result))
    {
        Console.WriteLine("Only numbers allowed!");
    }
    else
    {
        listOfNumbers.Add(Convert.ToInt32(input));
    }
}

int runningTotal = 0;

for (int counter = 0; counter < listOfNumbers.Count; counter += 1)
{
    int currentElement = listOfNumbers[counter];
    runningTotal += currentElement;
}

Console.WriteLine($"The total is: {runningTotal}");