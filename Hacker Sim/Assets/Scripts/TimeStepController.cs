using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class TimeStepController
{
    public static void TimeEvent(int minutes, SEAttributes player, string currState)
    {
        if (minutes % 7 == 0) // In ~ 12 hours (1 day), their hunger, tiredness and fitness will be at 0
        {
            SEAttributesController.IncreaseHunger(player);
            SEAttributesController.IncreaseTired(player);
            SEAttributesController.DecreaseFitness(player);
        }

        if (currState == "entertainment")
        {
            SEAttributesController.IncreaseMood(player);
        }

        if (currState == "working")
        {
            SEAttributesController.DecreaseMood(player);
            if (minutes % 2 == 0)
            {
                SEAttributesController.IncreaseTired(player);
            }
        }

        if (currState == "exercising")
        {
            SEAttributesController.IncreaseFitness(player);
        }
    }
}
