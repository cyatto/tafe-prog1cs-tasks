namespace _04VolumeOfASphere;

// use Math.PI to access pi
using System;

class Program
{
    static void Main(string[] args)
    {
        // input args: radius
        // to access pi --> use Math.PI
        // formula: V = (4/3) * PI * r^3

        // map input args
        string input_radius = args[0];

        // convert string to number
        double radius = double.Parse(input_radius);

        // access pi
        double piValue = Math.PI;

        // access Math.Pow
        double baseNum = radius;
        double exponent = 3;

        // calculate vol of sphere
        // use 4.0 and 3.0 to avoid integer division
        double volume = (4.0/3.0) * piValue * Math.Pow(baseNum, exponent);

        // Output
        Console.WriteLine("The radius inputted of the sphere: " + radius);
        Console.WriteLine("Volume is: " + volume.ToString("F5"));
    }
}
