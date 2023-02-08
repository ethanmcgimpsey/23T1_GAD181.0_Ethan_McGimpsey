using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EthanMcGimpsey.SimpleLevelLoader
{
    public class SceneLoader : MonoBehaviour
    {
        // need a feature that loads X scene when trigger is collided with player
        [SerializeField] private int sceneToLoad;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                // Load the specified scene
                SceneManager.LoadScene(sceneToLoad);
                Debug.Log("Reloaded the same scene");
            }
        }
    }
}
