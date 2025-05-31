using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product product1 = new Product("Berries", "B19", 1.05, 2);
        Product product2 = new Product("Bread", "B10", 3.01, 3);
        Product product3 = new Product("Cerals", "A19", 4.05, 2);
        Address address1 = new Address("Rivera Indarte 237", "Cordoba", "Argentina");
        Customer customer1 = new Customer("Florencia Taravella", address1);
        Order order1 = new Order(customer1, product1, address1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total: $ {order1.TotalCost()}");
    

        Product product11 = new Product("Tomatoes", "T15", 0.25, 5);
        Product product22 = new Product("Coke", "CN5", 1.4, 3);
        Product product33 = new Product("Candy bar", "L54", 2.71, 4);
        Address address11 = new Address("Carlos Saberin 54", "Catamarca", "Argentina");
        Customer customer11 = new Customer("Diego Perez", address11);
        Order order11 = new Order(customer11, product11, address11);
        order11.AddProduct(product11);
        order11.AddProduct(product22);
        order11.AddProduct(product33);

        Console.WriteLine(order11.PackingLabel());
        Console.WriteLine(order11.ShippingLabel());
        Console.WriteLine($"Total: $ {order11.TotalCost()}");
    

        Product product111 = new Product("Bananas", "K15", 0.25, 4);
        Product product222 = new Product("Sprite", "J5", 1.78, 3);
        Product product333 = new Product("Chocolate bar", "L44", 2.78, 1);
        Address address111 = new Address("5th street", "Colesville", "USA");
        Customer customer111 = new Customer("Frank Kafka", address111);
        Order order111 = new Order(customer111, product111, address111);
        order111.AddProduct(product111);
        order111.AddProduct(product222);
        order111.AddProduct(product333);

        Console.WriteLine(order111.PackingLabel());
        Console.WriteLine(order111.ShippingLabel());
        Console.WriteLine($"Total: $ {order111.TotalCost()}");
        
    }
}