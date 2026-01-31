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
        order1.AddProduct(new Product("Starfighter", "001", 35, 10));
        order1.AddProduct(new Product("Tank", "002", 20, 10));
        order1.AddProduct(new Product("Drone", "003", 1, 100));

        Address address2 = new Address("No. 93 West Nahid Blvd Valiar St", "Tehran", "Republic of Iran", "Iran");
        Customer customer2 = new Customer("Imam Khomeini", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("PeaShooter", "004", 5, 100));
        order2.AddProduct(new Product("Running Shoes", "005", 20, 1000));
        order2.AddProduct(new Product("White Flag", "006", 10, 1));

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);


        foreach (var Order in orders)
        {
            Order.Display();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost : ${order1.TotalCost()}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }
    }
}

// trying tofigure out how to add the lines to seperate each order like if you have a label printer os has a seperator between labels so youcan cut them apart
