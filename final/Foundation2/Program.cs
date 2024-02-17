using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1234 Main Street", "Salt Lake City", "UT", "USA");
        Address a2 = new Address("7921 Tatehara", "Yori", "Saitama", "Japan");

        Customer c1 = new Customer("John Johnson", a1);
        Customer c2 = new Customer("Daijiro Sagane", a2);

        Product p1 = new Product("CD", "01", 20, 3);
        Product p2 = new Product("Guitar", "02", 3000, 1);
        Product p3 = new Product("Drum", "03", 5000, 1);

        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Order o2 = new Order(c1);
        o2.AddProduct(p1);
        o2.AddProduct(p2);
        o2.AddProduct(p3);

        Console.WriteLine("\nOrder 1 Packing Label:");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + o1.GetTotalCost());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + o2.GetTotalCost());
    }
}