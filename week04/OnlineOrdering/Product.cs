using System;
using System.Collections.Generic;
public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string DisplayProduct()
    {
        return _productName + " " + "(" + _productID + ")";
    }
    public double DisplayTotalCostProducts()
    {
        return  _price * _quantity;
    }
}