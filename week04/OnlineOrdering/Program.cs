using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------");

        Address address1 = new Address("569 E Center St", "Spanish Fork", "UT", "USA");
        Customer customer1 = new Customer("Kenny Johnson", address1);
        Order order1 = new Order(customer1);
        /* order of product info name, productId, price, quantity */
        order1.AddProdcut(new Product("Starfighter", "001", 35, 10));
        order1.AddProdcut(new Product("Tank", "002", 20, 10));
        order1.AddProdcut(new Product("Drone", "003", 1, 100));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost : ${order1.TotalCost()}");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("");        
    }
}

// trying tofigure out how to add the lines to seperate each order like if you have a label printer os has a seperator between labels so youcan cut them apart
