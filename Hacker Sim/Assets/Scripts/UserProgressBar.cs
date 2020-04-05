using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserProgressBar : MonoBehaviour
{
    public UserAttributes user;
    public int max;
    public float curr;
    public Image mask;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        user = SaveUserAttributes.LoadUser();
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        curr = (float)user.Exp;
        float fillAmount = curr / (float)max;
        mask.fillAmount = fillAmount;
    }
}
