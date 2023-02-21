using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedManager : MonoBehaviour
{
    [SerializeField] GameObject trigger;
    private int mainMenu = 0;
    private int gameScene = 1;
    private bool paused;

    public void ButtonToPlay()
    {
        SceneManager.LoadScene(gameScene);
    }
    public void ButtonToResume()
    {
        Time.timeScale = 1;
        trigger.SetActive(false);
        paused = !paused;
    }

    public void ButtonToRestart()
    {
        Time.timeScale = 1;
        trigger.SetActive(false);
        SceneManager.LoadScene(gameScene);
    }

    public void ButtonToMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
    public void ButtonToHowToPlay()
    {
        SceneManager.LoadScene(4);
    }
}
