using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainChar : MonoBehaviour
{
    public Sprite purpleRuckus, orangeRuckus, greenRuckus, whiteRuckus;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        int getCharacter;
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch(getCharacter)
        {
            case 1:
                mySprite.sprite = orangeRuckus;
                break;
            case 2:
                mySprite.sprite = greenRuckus;
                break;
            case 3:
                mySprite.sprite = whiteRuckus;
                break;
            case 4:
                mySprite.sprite = purpleRuckus;
                break;
            default:
                mySprite.sprite = purpleRuckus;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
