using System;
using System.Drawing;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)

    {
        _side = side;
    }
    public override double GetArea()
    {
        return  _side * _side;
    }

}