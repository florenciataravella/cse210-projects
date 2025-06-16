using System;
using System.Reflection.Metadata.Ecma335;

public class Shape
{
    private string _color;
    private double _area;

    public Shape (string color)
    {
        _color = color;
    }

    public void SetColor(string color)
    {
    _color = color;
        
    }
    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return _area;
    }
    
    
}