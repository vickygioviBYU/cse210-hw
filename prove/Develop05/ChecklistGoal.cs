using System;

class ChecklistGoal : Goal
{
    private int _pointsBonus;
    private int _timesBonus;
    private int _currentTimes;

    public override int GetPointsBonus() {
        return _pointsBonus;
    }

    public override int GetTimesBonus(){
        return _timesBonus;
    }

    public override int GetCurrentTimes(){
        return _currentTimes;
    }

    public override string ShowGoal() {
        string data;
        if (_currentTimes >= _timesBonus) {
            data = "X";
        } else {
            data = " ";
        }
        return "[" + data + "] " + _name + " " + "(" + _description + ")" + " -- " + "Currently Completed: " + _currentTimes + "/" + _timesBonus;
    }

    // name, description, pointsAssociated, bonus, pointsBonus

    public ChecklistGoal(string name, string description, int pointsAssociated, int bonus, int pointsBonus){
        _name = name;
        _description = description;
        _pointsAssociated = pointsAssociated;
        _timesBonus = bonus;
        _pointsBonus = pointsBonus;
        _goalType = "ChecklistGoal";
    }

    public override void AddTime() {
        _currentTimes++;
        if (TimesBonusEqualCurrentTimes()) {
            _currentPoints += _pointsBonus;
        }
    }

    public override bool TimesBonusEqualCurrentTimes(){
        if (_currentTimes == _timesBonus) {
            return true;
        } else {
            return false;
        }
    }
}