using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Mevcut bolumu ismiyle yukleme
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    // Sonraki bolumu yukleme
    public void LoadNextLevel()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(levelIndex);
    }

    // Onceki bolumu yukleme
    public void LoadBeforeLevel()
    {
        Time.timeScale = 1;

        int levelIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(levelIndex);
    }

    // Bolumu yeniden oynama
    public void RestartLevel()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(levelIndex);
    }

    // Oyundan cikis saglama
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
