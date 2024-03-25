
public class ClothingProduct : Product
{
    
    private readonly string size;
    private readonly string color;

    
    public string Size { get { return size; } }
    public string Color { get { return color; } }

    
    public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
        : base(name, price, category)
    {
        this.size = size;
        this.color = color;
    }

    //override method 
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Size: {size}, Color: {color}");
    }
}
