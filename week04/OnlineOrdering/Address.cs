using System;
using System.Collections.Generic;

public class Address
{
    private string _steet;
    private string _city;
    private string _country;



    public Address(string street, string city, string country)

    {
        _steet = street;
        _city = city;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }
    public string GetAddress()
    {
        string address = "Street: " + _steet + Environment.NewLine + "City: " + _city + Environment.NewLine + "Country: " + _country;
        return address;
    }
    public bool Country()
    {
        if (GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}