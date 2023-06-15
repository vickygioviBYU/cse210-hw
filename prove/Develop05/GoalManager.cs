using System;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public List<Goal> Goals() {
        return _goals;
    }
    private int _points;
    public void DisplayAllGoals() {
        string data = "";
        for(int i=1; i<=_goals.Count(); i++) {
            data += i.ToString() + ". " + _goals[i - 1].ShowGoal();
            data += "\n";
        }
        Console.WriteLine(data);
    }

    public void newGoal(Goal goal){
        _goals.Add(goal);
    }

    public Goal ObtainGoal(int index) {
        return _goals[index];
    }

    public int getPoints(){
        return _points;
    }

    public void AddCurrentPoints(int points) {
        _points += points;
    }
}