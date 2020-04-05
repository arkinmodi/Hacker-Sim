using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SEAttributes 
{
    private string playerName;
    private string playerGender;
    private int playerAge;
    private double playerCurrency;

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

    public int PlayerAge
    {
        get { return playerAge; }
        set { playerAge = value; }
    }

    public double PlayerCurrency
    {
        get { return playerCurrency; }
        set { playerCurrency = value; }
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
