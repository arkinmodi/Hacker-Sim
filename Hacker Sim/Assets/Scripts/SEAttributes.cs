using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEAttributes 
{
    private string playerName;
    private string playerGender;

    // Stats
    private int mood;
    private int tired;
    private int hunger;
    private int fitness;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public string PlayerGender
    {
        get { return playerGender; }
        set { playerGender = value; }
    }

    public int Mood
    {
        get { return mood; }
        set { mood = value; }
    }

    public int Tired
    {
        get { return tired; }
        set { tired = value; }
    }

    public int Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }

    public int Fitness
    {
        get { return fitness; }
        set { fitness = value; }
    }
}
