using System;

class SimpleGoal : Goal
{
    private bool _completed;

    public override string ShowGoal() {
        string data;
        if (_completed) {
            data = "X";
        } else {
            data = " ";
        }
        return "[" + data + "] " + _name + " " + "(" + _description + ")";
    }

    public SimpleGoal(string name, string description, int pointsAssociated){
        _name = name;
        _description = description;
        _pointsAssociated = pointsAssociated;
        _completed = false;
        _goalType = "SimpleGoal";
    }

    public override void setCompleted(bool completed){
        _completed = completed;
    }

    public override bool isComplete() {
        return _completed;
    }
}