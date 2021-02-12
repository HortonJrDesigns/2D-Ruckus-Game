using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainRiderFront : MonoBehaviour
{
    public Sprite purpleRuckus, orangeRuckus, greenRuckus, whiteRuckus;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";
    public  GameObject Bag;

    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
        Bag.SetActive(false);
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
                Bag.SetActive(false);
                break;
            case 2:
                mySprite.sprite = greenRuckus;
                Bag.SetActive(true);
                break;
            case 3:
                mySprite.sprite = whiteRuckus;
                Bag.SetActive(false);
                break;
            case 4:
                mySprite.sprite = purpleRuckus;
                Bag.SetActive(false);
                break;
            default:
                mySprite.sprite = purpleRuckus;
                Bag.SetActive(false);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
