class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }

        // Add shipping cost based on customer location
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:";
        foreach (var product in products)
        {
            packingLabel += $"\n\t{product.Name} (ID: {product.ProductID})";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        return "Shipping Label:\n" + customer.ToString();
    }
}