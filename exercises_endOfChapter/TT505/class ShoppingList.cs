// namespace _03ShoppingList;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }

// declare public class ShoppingList (a reference type, accessible from anywhere)
class ShoppingList
{    
    // private fields --> underscore is convention for private field
    // `= new string[0];` --> intialise empty array immediately so that it is never null before any items are added
    public string[] products = new string[0];
    public int[] quantities = new int[0];
    
    // empty constructor
    public ShoppingList() { }

    // method for adding new item
    public void AddItem(string product, int quantity)
    {
        // create two new local arrays with the variable names newProducts and newQuantities,
        // each is sized one element larger than the current products/quantities arrays
        // .Length() gets the current array's size; +1 makes room for the new array to be added

        string[] newProducts = new string[products.Length + 1];
        int[] newQuantities = new int[quantities.Length + 1];

        // both new arrays are filled with default values when initialised
        // null for strings
        // 0 for ints

        // for loop --> iterates over the OLD length;
        // the last slot in each new array is reserved for the newly added item, not a copy

        for (int i = 0; i < products.Length; i++)
        {
            // copy operations per iteration
            // keeps the arrays paired
            // copies are passed into the new arrays
            newProducts[i] = products[i];
            newQuantities[i] = quantities[i];
        }

        newProducts[products.Length] = product;
        newQuantities[quantities.Length] = quantity;

        products = newProducts;
        quantities = newQuantities;
    }

    public string[] Details()
    {
        string[] result = new string[products.Length];

        for (int i = 0; i < products.Length; i++)
        {
            result[i] = $"{products[i]}: {quantities[i]}";
        }

        return result;
    }
}