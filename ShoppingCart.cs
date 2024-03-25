public class ShoppingCart
{
    
    private List<Product> products;

    
    public ShoppingCart()
    {
        products = new List<Product>();
    }

    //adding item to cart
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    //displaying cart
    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (var product in products)
        {
            product.GetInfo();
        }
    }
}