class Product
{
    private string name;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
    }

    public string ProductID
    {
        get { return productId; }
    }

    public double CalculateTotalCost()
    {
        return pricePerUnit * quantity;
    }
}