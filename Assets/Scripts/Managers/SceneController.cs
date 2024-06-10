using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Mevcut b�l�m� ismiyle y�kleme
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    // Sonraki b�l�m� y�kleme
    public void LoadNextLevel()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(levelIndex);
    }

    // �nceki b�l�m� y�kleme
    public void LoadBeforeLevel()
    {
        Time.timeScale = 1;

        int levelIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(levelIndex);
    }

    // B�l�m� yeniden oynama
    public void RestartLevel()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(levelIndex);
    }

    // Oyundan ��k�� sa�lama
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
