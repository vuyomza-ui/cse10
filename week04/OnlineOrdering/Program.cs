using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------
        // ORDER 1
        // -------------------------

        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "P100",
            999.99,
            1
        );

        Product product2 = new Product(
            "Mouse",
            "P200",
            25.50,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "P300",
            50.00,
            1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // -------------------------
        // ORDER 2
        // -------------------------

        Address address2 = new Address(
            "45 King Street",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer(
            "Mary Johnson",
            address2
        );

        Product product4 = new Product(
            "Headphones",
            "P400",
            75.00,
            1
        );

        Product product5 = new Product(
            "USB Cable",
            "P500",
            10.00,
            3
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);


        // -------------------------
        // DISPLAY ORDER 1
        // -------------------------

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=================================");

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTOTAL COST: ${order1.GetTotalCost():0.00}");


        // -------------------------
        // DISPLAY ORDER 2
        // -------------------------

        Console.WriteLine("\n=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=================================");

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTOTAL COST: ${order2.GetTotalCost():0.00}");
    }
}