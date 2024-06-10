using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public CountdownTimer [] gameTimer;

    public GameObject [] endGamePanel;

    [SerializeField] private float coin = 0;
    [SerializeField] private float key = 0;

    public bool checkKey = false;
    public bool checkLevel = false;


    [SerializeField] private TextMeshProUGUI [] collectCoinText;
    [SerializeField] private TextMeshProUGUI [] collectKeyText;

    [SerializeField]
    private TextMeshProUGUI []endGameText;

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
        // Altin topladiginda ui'daki altin sayisini guncelle
        coin++;
        collectCoinText[0].text = coin.ToString();
        collectCoinText[1].text = coin.ToString();
    }

    public void CollectKey()
    {
        // Anahtar topladiginda ui'daki anahtar sayisini guncelle
        key++;
        collectKeyText[0].text = key.ToString();
        collectKeyText[1].text = key.ToString();

        checkKey = true;
    }

    public void EndGame()
    {
        // Yatay veya Dikey UI'daki zaman bittiginde ve anahtar 1'e esitse bolumu bitir

        if (gameTimer[0].timeRemaining > 0 || gameTimer[1].timeRemaining > 0)
        {
            if (checkLevel)
            {
                Debug.Log(checkLevel);
                
                Time.timeScale = 0;

                endGamePanel[0].SetActive(true);
                endGamePanel[1].SetActive(true);

                endGameText[0].text = "Next Level";
                endGameText[1].text = "Next Level";
            }
        }
        // Yatay veya Dikey UI'daki zaman bittiginde karakter bolumu tamamlamamissa bolumu bitir

        if (gameTimer[0].timeRemaining <= 0 || gameTimer[1].timeRemaining <= 0)
        {
                checkLevel = true;
                Time.timeScale = 0;

                endGamePanel[0].SetActive(true);
                endGamePanel[1].SetActive(true);

                endGameText[0].text = "Game Over";
                endGameText[1].text = "Game Over";
        }
    }
}
