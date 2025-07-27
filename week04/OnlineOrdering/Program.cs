using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Customer 1 - USA
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Notebook", "NB001", 3.99, 4));
        order1.AddProduct(new Product("Pen", "PN002", 1.49, 6));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // Customer 2 - Non-USA
        Address address2 = new Address("45 Mayne Avenue", "Calabar", "CR", "Nigeria");
        Customer customer2 = new Customer("Elizabeth Ekpenyong", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Water Bottle", "WB003", 12.99, 2));
        order2.AddProduct(new Product("Backpack", "BP004", 45.00, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}