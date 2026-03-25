using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Product product1 = new Product("Shirt", "SHRT", 15.99f, 2);
        Product product2 = new Product("Pants", "PANTS", 29.99f, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order();
        Product product3 = new Product("Shoes", "SHOE", 49.99f, 1);
        Product product4 = new Product("Hat", "HAT", 19.99f, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order();
        Product product5 = new Product("Socks", "SOCK", 5.99f, 3);
        Product product6 = new Product("Belt", "BELT", 14.99f, 1);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        order1.SetCustomer(new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA")));
        order2.SetCustomer(new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "ON", "Canada")));
        order3.SetCustomer(new Customer("Bob Johnson", new Address("789 Oak St", "Sometown", "TX", "USA")));


        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: {order1.CalcualteTotalCost()}");
        Console.WriteLine("-----------------------------");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: {order2.CalcualteTotalCost()}");
        Console.WriteLine("-----------------------------");
        order3.DisplayPackingLabel();
        order3.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: {order3.CalcualteTotalCost()}");
        Console.WriteLine("-----------------------------");
    }
}