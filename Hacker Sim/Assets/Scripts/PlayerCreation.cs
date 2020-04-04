using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // To deal with Unity UI elements

public class PlayerCreation : MonoBehaviour
{ 
    public SEAttributes newPlayer = new SEAttributes();
    private string playerName;
    private string playerGender;
    public GameObject inputField; // Where we are typing the text

    public void SelectMale()
    {
        playerGender = "male";
    }

    public void SelectFemale()
    {
        playerGender = "female";
    }
    public void CreatePlayer()
    {
        playerName = inputField.GetComponent<Text>().text;
        newPlayer.PlayerName = playerName;
        newPlayer.PlayerGender = playerGender;
        newPlayer.Mood = 100;
        newPlayer.Hunger = 100;
        newPlayer.Tired = 100;
        newPlayer.Fitness = 100;

        SaveSEAttributes.SavePlayer(newPlayer);

        // Testing
        Debug.Log("Player Name: " + newPlayer.PlayerName);
        Debug.Log("Player Gender: " + newPlayer.PlayerGender);
    }


