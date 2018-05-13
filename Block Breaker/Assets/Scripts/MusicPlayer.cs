using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Static variable for singleton
    public static MusicPlayer instance = null;

    private void Awake()
    {
        // Moved code to Awake to stop any duplicate players

        if (instance != null)
        {
            print("Destroying Awake Music Player");
            Destroy(gameObject);
        }
        else
        { 
            // Cause background music to continue playing across scenes
            GameObject.DontDestroyOnLoad(gameObject);

            // Set the instance to the first music player
            instance = this;
        }
    }
}
