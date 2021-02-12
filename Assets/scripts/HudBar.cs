using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudBar : MonoBehaviour
{
    // set GUI bar width and Height in the Inspector
    public float barWidth = 424;
    public float barHeight = 9;

    // drag a texture as the icon to move on the progress bar
    public Texture progIcon;

    // where to set the GUI element to
    private float barProgress;

    // empty objects repersent the start ans the end of a level
    public Transform startPoint;
    public Transform endPoint;

    // current Player position
    public Transform playerPos;


    // Update is called once per frame
    void Update()
    {
        // get level distance by subtracting start and end
        float totalDist = endPoint.position.x - startPoint.position.x;

        // get player distance from start in X axis only so slopes/ height dosent affect result
        float playerDist = playerPos.position.x - startPoint.position.x;

        //get player's progress as a percentage of the whole distance
        float playerProgress = playerDist / totalDist * 100;

        // turn the playerProgress percentage back into the scale of barWidth
        barProgress = playerProgress / 100 * barWidth;

    }

    void OnGUI()
    {
    // create a GUI group the width of the bar and twice its height
    // in order to leave room for 'Start' and 'End' text under the bar
    GUI.BeginGroup (new Rect (300, 10, barWidth, barHeight*2)); 
        //GUI.BeginGroup (new Rect (850, 10, barWidth, barHeight*2));

        //draw a box as the backing for the progress bar, blank text inside
        GUI.Box(new Rect(0,0,barWidth,barHeight),"");
 
    // create a label to draw the progress icon texture, use barProgress var
    // to set its X position, 0 as the Y position and width and height of the texture used
    GUI.Label (new Rect (barProgress, 0, progIcon.width, progIcon.height),
        progIcon);
 
    // add start and end labels
    GUI.Label(new Rect(progIcon.width/2, 25, 50, barHeight),"Start");
    GUI.Label(new Rect(barWidth-30, 25, 100, barHeight),"End");
 
    GUI.EndGroup();

    }
}
