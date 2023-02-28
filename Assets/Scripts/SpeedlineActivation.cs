using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedlineActivation : MonoBehaviour
{
    [SerializeField] public GameObject speedLines;
    private void Start()
    {
        speedLines.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            speedLines.SetActive(true);
            Debug.Log("hi");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            speedLines.SetActive(false);
        }

    }
}
