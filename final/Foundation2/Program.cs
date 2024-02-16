using System;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address address1 = new Address("210 W Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Oak St", "Edmonton", "AB", "Canada");

        // Customers
        Customer customer1 = new Customer("Dark Vader", address1);
        Customer customer2 = new Customer("Bob Ross", address2);

        // Products
        Product product1 = new Product("Novel", "001", 10.5, 2);
        Product product3 = new Product("Journal", "002", 8.0, 1);
        Product product2 = new Product("Art Kit", "003", 15.75, 3);

        // Orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

        // Display
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}