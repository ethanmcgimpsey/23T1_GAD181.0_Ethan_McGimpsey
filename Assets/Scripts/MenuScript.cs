using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject trigger;
    private bool paused;
    void Start()
    {
        trigger.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if (paused)
            {
                //Pauses Time and player movement and sets Paused menu to be active
                Time.timeScale = 0;
                trigger.SetActive(true);
            }
            else
            {
                //Unpauses the game by disabling everything else
                Time.timeScale = 1;
                trigger.SetActive(false);
            }
        }
    }
}
