using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeRemaining = 60;

    private bool timerIsRunning = false;

    void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        Timer();
    }

    public void Timer() 
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                DisplayTime(timeRemaining);
            }
        }
    }

    public void DisplayTime(float timeToDisplay)
    {
        // Sure 0'dan az ise sureyi 0'a esitle

        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        // Dakika ve saniye olarak ayarla ve ekranda goster

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{00:00}:{1:00}", minutes, seconds);
    }
}
