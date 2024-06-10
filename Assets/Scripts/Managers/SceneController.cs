using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Mevcut bölümü ismiyle yükleme
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    // Sonraki bölümü yükleme
    public void LoadNextLevel()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(levelIndex);
    }

    // Önceki bölümü yükleme
    public void LoadBeforeLevel()
    {
        Time.timeScale = 1;

        int levelIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(levelIndex);
    }

    // Bölümü yeniden oynama
    public void RestartLevel()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(levelIndex);
    }

    // Oyundan çýkýþ saðlama
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
