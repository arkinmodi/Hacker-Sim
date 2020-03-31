using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAttributes
{
    private double currency;
    private double exp;
    private List<string> friends; // A list containing the usernames of friends

    public double Currency
    {
        get { return currency; }
        set { currency = value; }
    }

    public double Exp
    {
        get { return exp; }
        set { exp = value; }
    }

    public List<string> Friends
    {
        get { return friends; }
        set { friends = value; }
    }

}
