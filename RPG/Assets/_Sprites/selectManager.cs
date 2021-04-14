using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mario;
    public GameObject bandit;

    private Vector3 onScreen  ;
    private Vector3 offscreen ;

    private int characterInt = 1; 

    public int defaultLives;

    public string nextLevel;

    public void Start(){
        PlayerPrefs.SetInt("CurrentLives", defaultLives);
    }

    void Awake(){

        onScreen = mario.transform.position ;
        offscreen = bandit.transform.position ;
       
    }

    public void NextCharacter(){
 
        switch(characterInt)
        {
            case 1:
                mario.transform.position = offscreen;
                bandit.transform.position = onScreen;
                characterInt ++;
                break;
            case 2:
                mario.transform.position = onScreen;
                bandit.transform.position = offscreen;
                characterInt --;
                break;
            default:
                break;

        } 


    }

    public void PlayGame()
    {
        if(mario.transform.position == onScreen){
            SceneManager.LoadScene("MLevel1");
        }else{
            SceneManager.LoadScene("BanditLevel1");
        }
        
    }

}
