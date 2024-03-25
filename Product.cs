public enum ProductCategory
{
    Clothing,
    Electronics,
    Home,
    Beauty,
    Groceries
}


public class Product
{
   
    private string name;
    private double price;
    private ProductCategory category;
    private int quantity;

    //getters
    public string Name { get { return name; } }
    public double Price { get { return price; } }
    public ProductCategory Category { get { return category; } }
    public int Quantity { get { return quantity; } }

    
    public Product(string name, double price, ProductCategory category)
    {
        this.name = name;
        this.price = price;
        this.category = category;
        this.quantity = 0;
    }

    //method for quantity
    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    //method for product info
    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Price: R{price:N2}, Category: {category}, Quantity: {quantity}");
    }

}
