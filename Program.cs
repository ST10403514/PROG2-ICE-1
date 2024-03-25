public class Program
{
  
    public static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        //items and prices
        List<Product> availableProducts = new List<Product>
        {
            new Product("Shirt", 20.99, ProductCategory.Clothing),
            new Product("Jacket", 49.99, ProductCategory.Clothing),
            new Product("Jeans", 39.99, ProductCategory.Clothing),
            new Product("Sneakers", 59.99, ProductCategory.Clothing)
        };


        Console.WriteLine("Available Products:");
        for (int i = 0; i < availableProducts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {availableProducts[i].Name} - R{availableProducts[i].Price:N2}");
        }

        //asking for user input
        Console.WriteLine("Enter the numbers of the items you want to add to the cart (comma to separate items):");
        string[] selections = Console.ReadLine().Split(',');

        //add to cart
        foreach (var selection in selections)
        {
            int index = int.Parse(selection.Trim()) - 1;
            if (index >= 0 && index < availableProducts.Count)
            {
                Console.WriteLine($"Enter quantity for {availableProducts[index].Name}:");
                int quantity = int.Parse(Console.ReadLine());
                availableProducts[index].SetQuantity(quantity);
                cart.AddProduct(availableProducts[index]);
            }
            else
            {
                Console.WriteLine($"Invalid selection: {selection}. Skipping...");
            }
        }

        //display cart
        cart.DisplayCart();
    }
}