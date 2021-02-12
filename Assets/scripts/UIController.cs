using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour
{

    public static bool isRaceBtnDown;
    public static bool isBrakeBtnDown;

    private void Start()
    {
        isRaceBtnDown = false;
        isBrakeBtnDown = false;
    }
   
    public void RaceBtnDown()
    {
        isRaceBtnDown = true;
        Debug.Log("You Press Race Button");
    }

    public void RaceBtnUp()
    {
        isRaceBtnDown = false;
        Debug.Log("You Not Press Race Button");
    }

    public void BrakeBtnDown()
    {
        isBrakeBtnDown = true;
        Debug.Log("You Press Brake Button");
    }
    
     public void BrakeBtnUp()
    {
        isBrakeBtnDown = false;
        Debug.Log("You Not Press Brake Button");
    }
}
