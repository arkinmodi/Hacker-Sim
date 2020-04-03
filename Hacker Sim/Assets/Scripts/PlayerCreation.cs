using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // To deal with Unity UI elements

public class PlayerCreation : MonoBehaviour
{ 
    public SEAttributes newPlayer = new SEAttributes();
    private string playerName;
    private string playerGender;
    // private bool isMale;
    // private bool isFemale;
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

        // Testing
        Debug.Log("Player Name: " + newPlayer.PlayerName);
        Debug.Log("Player Gender: " + newPlayer.PlayerGender);
    }



    //private void OnGUI()
    //{
    //    isMale = GUILayout.Toggle(isMale, "Male");
    //    isFemale = GUILayout.Toggle(isFemale, "Female");
    //    if (GUILayout.Button("Create"))
    //    {
    //        if (isMale)
    //        {
    //            newPlayer.PlayerGender = "Male";
    //        } else if (isFemale)
    //        {
    //            newPlayer.PlayerGender = "Female";
    //        }
    //    }
    //}
}
