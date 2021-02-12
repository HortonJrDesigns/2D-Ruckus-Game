using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceToCheckpoint1 : MonoBehaviour
{
    //Reference to checkpoint position
    [SerializeField]
    private Transform checkpoint;

    //Reference to Ui text that shows the distance value
    [SerializeField]
    private Text distanceText;
    

    // calculated distance value
    private float distance;

    //update is called once per frame
    public void Update()
    {
        //calculate distance value by x axis
        distance = (checkpoint.transform.position.x - transform.position.x);
        
        //Display distance value via UI text
        //distance.ToString("F1") shows value with 1 digit after period
        //so 12.234 will be shown as 12.2 for example
        //distance.ToString("F2") will show 12,23 in this case
        distanceText.text = distance.ToString("F0");

        //If player reaches checkpoint then distance text shows "Finish!" word
        if(distance <= 0)
        {
            distanceText.text = "Finish!";
        }
    }
}
