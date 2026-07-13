static int FindWord(string[] words, string word)
{
    // search array of words
    // SET variables for 1) idx/counter, 2) current_word

    // loop over array --> SET current_word to current element
    // if current_word == search_word --> break out of loop and return index 
    // else if reach end of array and no matching word, return -1

    // SET index/counter
    int counter = 0;

    // begin loop
    while (counter < words.Count())
    {
        string current_word = words[counter];

        if (current_word == word)
        {
            return counter;
        }

        counter++;
    }

    return -1;
}

string[] allwords = ["Hello", "Good", "Today", "Tomorrow", "Time", "Puzzle"];
int loc1 = FindWord(allwords, "Good"); // 1
Console.WriteLine(loc1);

int loc2 = FindWord(allwords, "Time"); // 4
Console.WriteLine(loc2);

int loc3 = FindWord(allwords, "Jigsaw"); // -1
Console.WriteLine(loc3);

// Why is -1 a reasonable return value?
// Array indices in C# are always 0 or positive; an element cannot exist at index -1
// --> safe, umambiguous representation of saying "the value does not exist in this array"

// Why not return null instead?
// - method return type is int (a value type)
// - value types can't be null (only reference types can)
// to return null from this method, change the signature to `int?` (a nullable int)

// Built-in .net methods that follow same convention of returning -1 for signalling "not found"
// Array.IndexOf()
// string.IndexOf()