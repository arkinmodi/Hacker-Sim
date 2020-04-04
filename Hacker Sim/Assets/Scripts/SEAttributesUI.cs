using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEAttributesUI : MonoBehaviour
{
    public SEAttributes player;
    public GameObject nameText;
    public GameObject ageText;

    void Start()
    {
        player = SaveSEAttributes.LoadPlayer();
        nameText.GetComponent<Text>().text = player.PlayerName;
        ageText.GetComponent<Text>().text = "Age: " + player.PlayerAge;
    }
}
