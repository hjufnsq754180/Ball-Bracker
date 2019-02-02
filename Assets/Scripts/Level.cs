using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{ 
    // parameters
    [SerializeField] int breakableBlock; // Serialized for debugging purposes

    //cached reference
    Scene_Loader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<Scene_Loader>();
    }

    public void CountBreakableBlock()
    {
        breakableBlock++;
    }

    public void BlockDestroyed()
    {
        breakableBlock--;
        if (breakableBlock <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
