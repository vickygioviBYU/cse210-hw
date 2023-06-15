using System;

class Goal
{
    public string _goalType;
    protected string _name;
    protected string _description;

    public virtual int GetTimesBonus(){
        return -1;
    }

    public virtual int GetCurrentTimes(){
        return -1;
    }

    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _name;
    }


    protected int _pointsAssociated;
    protected int _currentPoints;
    public virtual void CreateNewGoal() {
        
    }

    public virtual string ShowGoal() {
        return "";
    }

    public int ObtainPointsAssociated() {
        return _pointsAssociated;
    }

    public void AddCurrentPoints(int points) {
        _currentPoints += points;
    }

    public virtual void setCompleted(bool completed){
        
    }

    public virtual bool isComplete() {
        return false;
    }

    public virtual void AddTime(){

    }

    public virtual bool TimesBonusEqualCurrentTimes(){
        return false;
    }

    public virtual int GetPointsBonus() {
        return -1;
    }
}