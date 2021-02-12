using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Selector_Script : MonoBehaviour
{
    public GameObject PlaceHolder;
    public GameObject PurpleRuckus;
    public GameObject OrangeRuckus;
    public GameObject GreenRuckus;
    public GameObject WhiteRuckus;

    private Vector3 CharacterPosition;
    private Vector3 OffScreen;
    private int CharacterInt = 1;
    private SpriteRenderer MomRender, KyleRender, RobertRender, DadRender;
    private readonly string selectedCharacter = "SelectedCharacter";
    private void Awake()
    {
        CharacterPosition = PlaceHolder.transform.position;
        OffScreen = OrangeRuckus.transform.position;
        MomRender = PurpleRuckus.GetComponent<SpriteRenderer>();
        KyleRender = OrangeRuckus.GetComponent<SpriteRenderer>();
        RobertRender = GreenRuckus.GetComponent<SpriteRenderer>();
        DadRender = WhiteRuckus.GetComponent<SpriteRenderer>();
    }

    public void NextCharacter()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                MomRender.enabled = false;
                PlaceHolder.SetActive(false);
                PurpleRuckus.transform.position = OffScreen;
                OrangeRuckus.transform.position = CharacterPosition;
                KyleRender.enabled = true;
                CharacterInt++;
                break;
            
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                KyleRender.enabled = false;
                OrangeRuckus.transform.position = OffScreen;
                GreenRuckus.transform.position = CharacterPosition;
                RobertRender.enabled = true;
                CharacterInt++;
                break;

            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                RobertRender.enabled = false;
                GreenRuckus.transform.position = OffScreen;
                WhiteRuckus.transform.position = CharacterPosition;
                DadRender.enabled = true;
                CharacterInt++;
                break;

            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                DadRender.enabled = false;
                WhiteRuckus.transform.position = OffScreen;
                PurpleRuckus.transform.position = CharacterPosition;
                MomRender.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            
            default:
                ResetInt();
                break;
        }
    }
    
    public void PreviousCharacter()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                MomRender.enabled = false;
                PlaceHolder.SetActive(false);
                PurpleRuckus.transform.position = OffScreen;
                WhiteRuckus.transform.position = CharacterPosition;
                DadRender.enabled = true;
                ResetInt();
                break;
            
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                KyleRender.enabled = false;
                OrangeRuckus.transform.position = OffScreen;
                PurpleRuckus.transform.position = CharacterPosition;
                MomRender.enabled = true;
                CharacterInt--;
                break;

            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                RobertRender.enabled = false;
                GreenRuckus.transform.position = OffScreen;
                OrangeRuckus.transform.position = CharacterPosition;
                KyleRender.enabled = true;
                CharacterInt--;
                break;

            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                DadRender.enabled = false;
                WhiteRuckus.transform.position = OffScreen;
                GreenRuckus.transform.position = CharacterPosition;
                RobertRender.enabled = true;
                CharacterInt--;
                break;
            
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if(CharacterInt >= 4)
        {
            CharacterInt = 1;
        }
        else
        {
            CharacterInt = 4;
        }
    }

    public void MiamiLevel()
  {
      SceneManager.LoadScene("Miami");
      Time.timeScale = 1f;
  }
  public void NewYorkLevel()
  {
      SceneManager.LoadScene("NewYork");
      Time.timeScale = 1f;
  }
  public void GrandCanyonLevel()
  {
      SceneManager.LoadScene("GrandCanyon");
      Time.timeScale = 1f;
  }
  public void DaytonaLevel()
  {
      SceneManager.LoadScene("Daytona");
      Time.timeScale = 1f;
  }
  public void BackRoadsLevel()
  {
      SceneManager.LoadScene("BackRoads");
      Time.timeScale = 1f;
  }

   public void LoadRandomScene()
 {
     // By Using The Random.Range method to load random scenes
     int index = Random.Range(1, 5);
     SceneManager.LoadScene(index);
     Debug.Log("Scene Loaded");
 }

}
