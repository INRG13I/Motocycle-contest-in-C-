namespace Motocycle_contest.Domain;

public class Organizer : IEntity
{
    private int id { get; set; }
    private String username{ get; set; }
    private String password{ get; set; }

    public Organizer(int id, string username, string password)
    {
        this.id = id;
        this.username = username;
        this.password = password;
    }


    public void setId(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return id;
    }
}