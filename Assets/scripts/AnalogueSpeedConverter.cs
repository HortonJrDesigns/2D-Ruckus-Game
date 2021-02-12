using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogueSpeedConverter : MonoBehaviour
{
    static float minAngle = 329.0f;
    static float maxAngle = 169.0f;
    static AnalogueSpeedConverter thisSpeedo;
    
    // Start is called before the first frame update
    void Start()
    {
      thisSpeedo = this;  
    }

    // Update is called once per frame
    public static void ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, ang);
    }
}
