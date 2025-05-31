using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Order
{
    List<Product> _products;
    Customer _customer;
    Address _country;

    public Order(Customer customer, Product product, Address country)
    {
        _products = new List<Product>();
        _customer = customer;
        _country = country;
    }
    public void AddProduct(Product newProduct)
    {

        _products.Add(newProduct);

    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += p.DisplayProduct();
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.DisplayCustomersInfo();
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.DisplayTotalCostProducts();
        }
        if (_country.Country() == true)
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }
        return total;
    }
    
}