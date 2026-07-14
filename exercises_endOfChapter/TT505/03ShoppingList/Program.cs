class ShoppingList
{
    // fields - parallel arrays for products and quantities
    private string[] _products = new string[0];
    private int[] _quantities = new int[0];

    // method for adding new item
    public void AddItem(string product, int quantity)
    {
        string[] updatedProducts = new string[_products.Length + 1];
        int[] updatedQuantities = new int[_quantities.Length + 1];

        for (int i = 0; i < _products.Length; i++)
        {
            updatedProducts[i] = _products[i];
            updatedQuantities[i] = _quantities[i];
        }

        updatedProducts[_products.Length] = product;
        updatedQuantities[_quantities.Length] = quantity;

        _products = updatedProducts;
        _quantities = updatedQuantities;
    }

    public string[] Details()
    {
        string[] allShoppingItems = new string[_products.Length];

        for (int i = 0; i < _products.Length; i++)
        {
            allShoppingItems[i] = $"{_products[i]}: {_quantities[i]}";
        }

        return allShoppingItems;
    }
}