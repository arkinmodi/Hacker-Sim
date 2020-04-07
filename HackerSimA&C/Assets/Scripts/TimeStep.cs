using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class TimeStep
{
    public static int prevtime = 0;

    public static void TimeEvent(int gameMinutes, SEAttributes player)
    {


        if (gameMinutes % 7 == 0 && gameMinutes != prevtime) // In ~ 12 hours (1 day), their hunger, tiredness and fitness will be at 0
        {
            SEAttributesController.IncreaseHunger(player);
            SEAttributesController.IncreaseTired(player);
            SEAttributesController.DecreaseFitness(player);
            //UnityEngine.Debug.Log(player.currState);
            // UnityEngine.Debug.Log(gameMinutes);
            prevtime = gameMinutes;
        }
        if(player.currState != "" && gameMinutes % 4 == 0 && gameMinutes != prevtime)
        {
          if (player.currState == "entertainment")
          {
              SEAttributesController.IncreaseMood(player);
          }

          else if (player.currState == "working")
          {
              SEAttributesController.DecreaseMood(player);
              if (gameMinutes % 2 == 0)
              {
                  SEAttributesController.IncreaseTired(player);
              }
          }

          else if (player.currState == "exercising")
          {
              SEAttributesController.IncreaseFitness(player);
          }
          prevtime = gameMinutes;
        }
    }
}
