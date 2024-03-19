namespace Motocycle_contest.Domain;

using System;
using System.Collections.Generic;

[Serializable]
public class Race : Identifier<int>
{
    private int id;
    private int capacity;
    private List<Participant> participants;

    public Race(int id, int capacity, List<Participant> participants)
    {
        this.id = id;
        this.capacity = capacity;
        this.participants = participants;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    public void SetCapacity(int capacity)
    {
        this.capacity = capacity;
    }

    public List<Participant> GetParticipants()
    {
        return participants;
    }

    public void SetParticipants(List<Participant> participants)
    {
        this.participants = participants;
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
