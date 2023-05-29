using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(double length, double width, string color) : base(color){
        _length = length;
        _width = width;
    }
    public double getLength(){
        return _length;
    }
    public void setLength(double length){
        _length = length;
    }
    public double getWidth(){
        return _width;
    }
    public void setWidth(double width){
        _width = width;
    }
    public override double getArea(){
        return _length * _width;
    }
    
}