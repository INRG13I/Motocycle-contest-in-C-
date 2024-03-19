namespace Motocycle_contest.Domain;

using System;

[Serializable]
public class Organizer : Identifier<int>
{
    private int id;
    private string username;
    private string password;

    public Organizer(int id, string username, string password)
    {
        this.id = id;
        this.username = username;
        this.password = password;
    }

    public string GetUsername()
    {
        return username;
    }

    public void SetUsername(string username)
    {
        this.username = username;
    }

    public string GetPassword()
    {
        return password;
    }

    public void SetPassword(string password)
    {
        this.password = password;
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
