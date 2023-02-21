using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartTimer : MonoBehaviour
{
    public float timer = 5f;
    public TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TMP_Text>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }
}
