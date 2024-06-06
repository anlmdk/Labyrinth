using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public CountdownTimer gameTimer;

    public GameObject endGamePanel;

    [SerializeField] private float coin = 0;
    [SerializeField] private float key = 0;

    public bool checkKey = false;
    public bool checkLevel = false;

    [SerializeField]
    private TextMeshProUGUI collectCoinText, collectKeyText;

    [SerializeField]
    private TextMeshProUGUI endGameText;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        coin = 0;
        key = 0;
        Time.timeScale = 1;
    }

    
    void Update()
    {
        EndGame();
    }

    public void CollectCoin()
    {
        coin++;
        collectCoinText.text = coin.ToString();
    }
    public void CollectKey()
    {
        key++;
        collectKeyText.text = key.ToString();

        checkKey = true;
    }
    public void EndGame()
    {
        if (gameTimer.timeRemaining > 0 && coin == 8 || key == 1)
        {
            if (checkLevel)
            {
                Time.timeScale = 0;

                endGamePanel.SetActive(true);
                endGameText.text = "Next Level";
            }
        }
        else if (gameTimer.timeRemaining < 0 || gameTimer.timeRemaining == 0)
        {
            Time.timeScale = 0;

            endGamePanel.SetActive(true);
            endGameText.text = "Game Over";

        }
    }
}
