using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address a1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer c1 = new Customer("Joe Kellso", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Pen", "P100", 1.50, 3));
        o1.AddProduct(new Product("Notebook", "N200", 4.00, 2));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + o1.GetTotalCost());
        Console.WriteLine();


        // Order 2
        Address a2 = new Address("77 King St", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Chuck Berry", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Water Bottle", "W300", 10.00, 1));
        o2.AddProduct(new Product("Backpack", "B400", 25.00, 1));
        o2.AddProduct(new Product("Pencil", "P101", 0.99, 5));

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + o2.GetTotalCost());
    }
}