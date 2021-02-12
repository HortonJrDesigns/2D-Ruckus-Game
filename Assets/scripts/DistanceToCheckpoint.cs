using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceToCheckpoint : MonoBehaviour
{
   // public float distanceBar = 0;
   // Reference to checkpoint position
   [SerializeField]
   private Transform checkpoint;

   // Reference to UI text that show the distance value
   [SerializeField]
   private Text distanceText;

   // Calculated distance value
   public float distance;
   //public UnityEngine.UI.Image image;

    
   // Update is called once per frame

   private void Update()
   {
      // image.fillAmount = distance;

       // Caluclate distance value by x axis
       distance = (checkpoint.transform.position.x - transform.position.x);

       // Display distance value via UI text
       // distance.Tostring("F1") show value with 1 digit after period
       // so 12.234 will be shown as 12.2 for example
       // distance.ToString("F2")will show 12.23 in this case
       distanceText.text = "Distance: " + distance.ToString("F1") + " meters";

       // If Bike reached checkpoint then distance text shows "Finish!: word
       if(distance <= 0)
       {
           distanceText.text = "Finish!";
       }
   }
}
