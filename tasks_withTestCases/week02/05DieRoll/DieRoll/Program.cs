// Console.WriteLine((new Random().Next() % 6) + 1);

// create an array of ints 1-6
int [] dieSixSides = {1, 2, 3, 4, 5, 6};

// choose from elements of array randomly
int randomSide = dieSixSides[Random.Shared.Next(dieSixSides.Length)];

//Console.WriteLine(dieSixSides[Random.Shared.Next(1)]);
//Console.WriteLine(dieSixSides[Random.Shared.Next(3)]);

Console.WriteLine(randomSide);