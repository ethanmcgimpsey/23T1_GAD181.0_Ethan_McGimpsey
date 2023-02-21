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
    public float Starttimer = 10f;
    public TMP_Text timerText;
    public TMP_Text startTimerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene(3);
        }

    }
    public void AddTime()
    {
        timer += 3f;
    }
}
