using System.ComponentModel;

class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal new_goal)
    {
        _goals.Add(new_goal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

}