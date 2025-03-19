using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 1000, 499.99, 1);
        Product product2 = new Product("Smartphone", 1001, 699.99, 2);
        Product product3 = new Product("Headphones", 1002, 199.99, 2);
        Product product4 = new Product("Monitor", 1003, 149.99, 1);
        Product product5 = new Product("Keyboard", 1004, 49.99, 2);
        Product product6 = new Product("Mouse", 1005, 29.99, 2);

        Address address1 = new Address("1029 N 4567 W", "Layton", "Utah", "United States of America");
        Address address2 = new Address("101 S Center Street", "Rexburg", "Idaho", "United States of America");
   
        Customer customer1 = new Customer("Josh Hansen", address1);
        Customer customer2 = new Customer("Jerry Zollinger", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine($"{order1.GetPackingLabel()}\n{order1.GetShippingLabel()}\n\n${order1.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine($"{order2.GetPackingLabel()}\n{order2.GetShippingLabel()}\n\n${order2.CalculateTotalCost()}");
        
    }
}