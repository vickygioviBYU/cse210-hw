using System;

public class Circle : Shape
{
    private double _radius;
    public Circle(double radius, string color) : base(color){
        _radius = radius;
    }
    public double getRadius(){
        return _radius;
    }
    public void setRadius(double radius){
        _radius = radius;
    }
    public override double getArea(){
        return _radius * _radius * Math.PI;
    }
    
}