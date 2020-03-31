using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreation : MonoBehaviour
{ 
    private SEAttributes newPlayer;
    private string playerName;
    private bool isMale;
    private bool isFemale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        isMale = GUILayout.Toggle(isMale, "Male");
        isFemale = GUILayout.Toggle(isFemale, "Female");
        if (GUILayout.Button("Create"))
        {
            if (isMale)
            {
                newPlayer.PlayerGender = "Male";
            } else if (isFemale)
            {
                newPlayer.PlayerGender = "Female;"
            }
        }
    }
}
