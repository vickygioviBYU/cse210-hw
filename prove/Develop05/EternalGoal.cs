using System;

class EternalGoal : Goal
{
    public override string ShowGoal() {
        return "[ ] " + _name + " " + "(" + _description + ")";
    }

    public EternalGoal(string name, string description, int pointsAssociated){
        _name = name;
        _description = description;
        _pointsAssociated = pointsAssociated;
        _goalType = "EternalGoal";
    }
}