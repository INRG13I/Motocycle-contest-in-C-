namespace Motocycle_contest.Domain;

public class Participant : IEntity
{
    private int id;
    private String name { get; set; }
    private int capacity { get; set; }
    private String team { get; set; }

    public Participant(int id, string name, int capacity, string team)
    {
        this.id = id;
        this.name = name;
        this.capacity = capacity;
        this.team = team;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return this.id;
    }
}