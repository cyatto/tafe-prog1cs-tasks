string inputA = args[0];
string inputB = args[1];
string inputC = args[2];
string inputD = args[3];

double a = Convert.ToDouble(inputA);
double b = Convert.ToDouble(inputB);
double c = Convert.ToDouble(inputC);
double d = Convert.ToDouble(inputD);

static double SumOfFour(string a, string b, string c, string d)
{
    double num1 = Convert.ToDouble(a);
    double num2 = Convert.ToDouble(b);
    double num3 = Convert.ToDouble(c);
    double num4 = Convert.ToDouble(d);

    return num1 + num2 + num3 + num4;
}

Console.WriteLine(SumOfFour(args[0], args[1], args[2], args[3]));