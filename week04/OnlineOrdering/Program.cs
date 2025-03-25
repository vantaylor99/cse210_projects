using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Jeff Bezos", "123 Richboy Lane, AppleCity CA USA");
        Customer customer2 = new Customer("Steve Madden", "489 Purse Street, Lima PERU");
        Customer customer3 = new Customer("Ricky Bobby", "7985 Chapstick Road, New York City NY USA");


        Product product1 = new Product("USB C Cable", "189FBG", 5.99, 4);
        Product product2 = new Product("Phone Case", "534JLK", 7, 1);
        Product product3 = new Product("Christus", "873UIO", 16.49, 2);
        Product product4 = new Product("Books", "725JLE", 20, 5);


        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        order1.AddProduct(product1);
        order1.AddProduct(product3);

        order2.AddProduct(product4);

        order3.AddProduct(product2);
        order3.AddProduct(product2);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLable());
        Console.WriteLine($"Total: ${order1.GetTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLable());
        Console.WriteLine($"Total: ${order2.GetTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine();



        Console.WriteLine(order3.GetPackingLable());
        Console.WriteLine();
        Console.WriteLine(order3.GetShippingLable());
        Console.WriteLine($"Total: ${order3.GetTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine();









    }
}