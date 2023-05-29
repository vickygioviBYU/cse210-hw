using System;

public class Square : Shape
{
    private double _side;
    public Square(double side, string color) : base(color){
        _side = side;
    }
    public double getSide(){
        return _side;
    }
    public void setSide(double side){
        _side = side;
    }
    public override double getArea(){
        return _side * _side;
    }
    
}