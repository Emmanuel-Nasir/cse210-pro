using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("13 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("14 Main St", "Los Angeles", "CA", "USA");

        // Create customers
        Customer customer1 = new Customer("Emmanuel Nasir", address1);
        Customer customer2 = new Customer("Samuel Nasir", address2);
        Customer customer3 = new Customer("Samson Obaji", address3);


        // Create products
        Product product1 = new Product("Laptop", "A1", 59.99, 1);
        Product product2 = new Product("Mouse", "B45", 9.99, 2);
        Product product3 = new Product("Keyboard", "C78", 89.99, 1);
        Product product4 = new Product("Earpod", "C9", 189.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product2);
        
        Order order3 = new Order(customer3);
        order3.AddProduct(product4);
        order3.AddProduct(product2);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost()}");

    }
    
}
