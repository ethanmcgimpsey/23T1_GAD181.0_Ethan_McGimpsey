using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public string LevelToLoad;
    public float timer = 10f;
    public float pauseTimer = 3f;
    public TMP_Text timerText;
    public TMP_Text pauseTimerText;
    
    public bool pauseStartTimer;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString("f2");
        pauseTimerText.text = pauseTimer.ToString("f0");
        if(pauseTimer >= 0)
        {
            pauseTimer -= Time.deltaTime;
            pauseStartTimer = true;
        }
        else 
        {
            pauseStartTimer = false;
            pauseTimerText.enabled = false;
        }

        if(pauseStartTimer == false)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene(3);
            }
        }

    }
    public void AddTime()
    {
        timer += 3f;
    }
}
