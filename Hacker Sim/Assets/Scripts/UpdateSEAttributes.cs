using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSEAttributes
{

    public static void IncreaseMood(SEAttributes player) // SE gets happier when using entertainment
    {
        player.Mood += 1;
        SaveSEAttributes.SavePlayer(player);
    }

    public static void DecreaseMood(SEAttributes player) // SE gets more sad when working
    {
        player.Mood -= 1;
        SaveSEAttributes.SavePlayer(player);
    }

    public static void IncreaseTired(SEAttributes player) // SE gets more tired over time
    {
        player.Tired -= 1;
        SaveSEAttributes.SavePlayer(player);
    }

    public static void Rest(SEAttributes player) // SE sleeps and is not tired
    {
        player.Tired = 100;
        SaveSEAttributes.SavePlayer(player);
    }

    public static void IncreaseHunger(SEAttributes player) // SE gets more hungry over time
    {
        player.Hunger -= 1;
        SaveSEAttributes.SavePlayer(player);
    }

    public static void DecreaseHunger(SEAttributes player) // When SE eats 
    {
        player.Hunger += 1;
        SaveSEAttributes.SavePlayer(player);
    }
}
