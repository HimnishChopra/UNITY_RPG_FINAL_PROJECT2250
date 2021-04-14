using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menus : MonoBehaviour
{
    public string nextLevel;
    public void Replay()
    {
    FindObjectOfType<GameManager>().Reset();
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}