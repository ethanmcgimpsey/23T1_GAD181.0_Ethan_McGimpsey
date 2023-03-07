using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameScene : MonoBehaviour
{
    public Timer timer;
    void Update()
    {
        if (timer.pauseTimer <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
