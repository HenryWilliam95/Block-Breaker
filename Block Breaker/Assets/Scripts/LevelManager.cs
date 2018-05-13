using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Reference to the button the script sits on
    public Button button;

    public void LoadLevel(int level)
    {
        // Load the level specified in inspector
        SceneManager.LoadScene(level);
    }

    public void Quit()
    {
        // Quit the application
        Application.Quit();
        print("Application quit");
    }
}
