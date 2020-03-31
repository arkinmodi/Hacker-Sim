using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEAttributes : MonoBehaviour
{
    private string playerName;
    private string playerGender;
    private List<(string, int)> playerAttributes;
    
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

    public List<(string, int)> PlayerAttributes
    {
        get { return playerAttributes; }
        set { playerAttributes = value; }
    }
}
