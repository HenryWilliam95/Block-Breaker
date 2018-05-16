using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void LoadLevel(int level)
    {
        // Load the level specified in inspector
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        // Quit the application
        Application.Quit();
        print("Application quit");
    }

    // When collision with bottom collider load lose scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Lose Scene");
    }
}
