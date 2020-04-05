using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserAttributesUI : MonoBehaviour
{
    public UserAttributes user;
    public GameObject friendsList;
    public GameObject currency;
    public GameObject level;

    // Start is called before the first frame update
    void Start()
    {
        user = SaveUserAttributes.LoadUser();
        level.GetComponent<Text>().text = "level: " + user.Level;
        currency.GetComponent<Text>().text = "$ " + user.Currency;
        for (int i = 0; i < user.Friends.Count; i++)
        {
            friendsList.GetComponent<Text>().text = user.Friends[i] + "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
