using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedlineActivation : MonoBehaviour
{
    [SerializeField] public GameObject speedLines;
    public Timer timer;
    private void Start()
    {
        speedLines.SetActive(false);
    }

    private void Update()
    {
        if(timer.pauseTimer <= 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                speedLines.SetActive(true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                speedLines.SetActive(false);
            }
        }
    }
}
