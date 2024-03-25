
public class ElectronicsProduct : Product
{
   
    private readonly string brand;
    private readonly string model;

    //getters
    public string Brand { get { return brand; } }
    public string Model { get { return model; } }

    
    public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
        : base(name, price, category)
    {
        this.brand = brand;
        this.model = model;
    }

    //overide method
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Brand: {brand}, Model: {model}");
    }
}