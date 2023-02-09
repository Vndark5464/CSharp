using System;

namespace Practice_Exam.Exam1;

class Cylinder
{
    private double _radius;
    private double _height;
    private double _baseArea;
    private double _lateralArea;
    private double _totalArea;
    private double _volume;

    public Cylinder(double radius, double height)
    {
        _radius = radius;
        _height = height;
    }

    public void Process()
    {
        _baseArea = _radius * _radius * Math.PI;
        _lateralArea = 2 * Math.PI * _radius * _height;
        _totalArea = 2 * Math.PI * _radius * (_height + _radius);
        _volume = Math.PI * _radius * _radius * _height;
    }

    public void Result()
    {
        Console.WriteLine("Base: " + _baseArea.ToString("0.00"));
        Console.WriteLine("Lateral: " + _lateralArea.ToString("0.00"));
        Console.WriteLine("Total: " + _totalArea.ToString("0.00"));
        Console.WriteLine("Volume: " + _volume.ToString("0.00"));
    }
}
