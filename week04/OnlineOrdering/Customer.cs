using System;
using System.Collections.Generic;
public class Customer
{
    private string _customersName;
    Address _customersAddress;

    public Customer(string customersName, Address customersAddress)
    {
        _customersName = customersName;
        _customersAddress = customersAddress;

    }
    public string GetCustomersName()
    {
        return _customersName;
    }
    public string DisplayCustomersInfo()
    {
        string info = "Customer's Name: " + GetCustomersName() + Environment.NewLine + "Address: " + _customersAddress.GetAddress();
        return info;
    }




}