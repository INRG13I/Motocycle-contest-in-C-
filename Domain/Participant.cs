namespace Motocycle_contest.Domain;

using System;

[Serializable]
public class Participant : Identifier<int>
{
    private int id;
    private string name;
    private int capacity;
    private string team;

    public Participant(int id, string name, int capacity, string team)
    {
        this.id = id;
        this.name = name;
        this.capacity = capacity;
        this.team = team;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    public void SetCapacity(int capacity)
    {
        this.capacity = capacity;
    }

    public string GetTeam()
    {
        return team;
    }

    public void SetTeam(string team)
    {
        this.team = team;
    }

    public int GetId()
    {
        return this.id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }
}
