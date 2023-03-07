using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFootstepAudio : MonoBehaviour
{
    public AudioSource footstepAudio;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S))
        {
            footstepAudio.enabled = true;
        }
        else
        {
            footstepAudio.enabled = false;
        }
    }
}
