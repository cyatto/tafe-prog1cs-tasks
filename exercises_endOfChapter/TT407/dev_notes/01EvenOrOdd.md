# Question prompt

```cs
namespace _01EvenOrOdd;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number greater than 0: ");
        string input = Console.ReadLine();
        double num = Convert.ToInt32(input);

        while (num >= 2)
        {
            num -= 2;
        }

        if (num == 1)
        {
            Console.WriteLine("odd");
        }
        else if (num == 0)
        {
            Console.WriteLine("even");
        }
        else if (num < 0)
        {
            Console.WriteLine("No negatives allowed!");
        }
    }
}

```

How to rewrite the while loop as a for loop

# Answer (Claude)

A `for` loop is just a `while` loop with its three moving parts — initializer, condition, and increment/update — pulled together into one line. Your `while` loop already has all three pieces, they're just scattered:

- **Initializer**: `num` is already set (from `Convert.ToInt32(input)`), so this slot can be left empty
- **Condition**: `num >= 2`
- **Update**: `num -= 2`

Putting those into the `for (init; condition; update)` shape:

```cs
namespace _01EvenOrOdd;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number greater than 0: ");
        string input = Console.ReadLine();
        double num = Convert.ToInt32(input);

        for (; num >= 2; num -= 2)
        {
        }

        if (num == 1)
        {
            Console.WriteLine("odd");
        }
        else if (num == 0)
        {
            Console.WriteLine("even");
        }
        else if (num < 0)
        {
            Console.WriteLine("No negatives allowed!");
        }
    }
}
```

Notice the initializer slot is just left blank (`for (;` with nothing before the first `;`) — you're allowed to skip any of the three parts if it's not needed, C# just requires the semicolons as placeholders.

A couple of notes:

- This is a bit of an unusual `for` loop since the body is empty — all the actual work happens in the update clause (`num -= 2`). That's valid C#, but it reads a little awkwardly. A `while` loop is arguably the more natural fit here, since the loop isn't really "counting" in the classic `for` sense (like `for (int i = 0; i < 10; i++)`) — it's better described as "keep going while this condition holds," which is literally what `while` means. Converting it was a good exercise, but in your own code you'd likely reach for `while` in this exact situation.
- Ruby's `for` loop doesn't map onto this at all, in case that's a mental trap — Ruby's `for x in collection` (or more commonly `.each`) iterates over a collection. C#'s `for` is closer to Ruby's `.step` or a manually-counted `while` loop.