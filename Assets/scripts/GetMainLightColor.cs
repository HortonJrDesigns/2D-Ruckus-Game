using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainLightColor : MonoBehaviour
{
    public Sprite purpleLight, orangeLight, greenLight, whiteLight;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        int getLight;
        getLight = PlayerPrefs.GetInt(selectedCharacter);

        switch(getLight)
        {
            case 1:
                mySprite.sprite = orangeLight;
                break;
            case 2:
                mySprite.sprite = greenLight;
                break;
            case 3:
                mySprite.sprite = whiteLight;
                break;
            case 4:
                mySprite.sprite = purpleLight;
                break;
            default:
                mySprite.sprite = purpleLight;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
