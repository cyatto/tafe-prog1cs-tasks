// // See https://aka.ms/new-console-template for more information

// Console.WriteLine("What is the radius of the sphere: ");
// string? rStr = Console.ReadLine();

// double r = double.Parse(rStr);

// double V = (4.0/3.0) * Math.PI * Math.Pow(r, 3.0);

// Console.WriteLine("Volume is: " + string.Format("{0:0.00000}", V));


// MY SCRIPT

using System;

// get user input (radius)
Console.WriteLine("What is the radius of the sphere: ");
string inputR = Console.ReadLine();

// convert string to number
double r = double.Parse(inputR);

// calculate volume using formula V = (4.0/3.0) * pi * r^3
// use Math.PI and Math.Pow(x, y);
double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

Console.WriteLine("Volume is: " + volume.ToString("F5"));