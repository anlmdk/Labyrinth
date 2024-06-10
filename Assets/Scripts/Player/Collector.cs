using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private string COIN = "Coin";
    private string KEY = "Key";
    private string FINISH = "Finish";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(COIN))
        {
            // Nesneyi yok et puan ekle 

            Debug.Log("Coin ile �arp��ma tespit edildi.");

            Destroy(collision.gameObject);

            GameManager.instance.CollectCoin();
        }
        else if (collision.gameObject.CompareTag(KEY))
        {
            // Nesneyi yok et kap�y� a�

            Debug.Log("Key ile �arp��ma tespit edildi.");

            Destroy(collision.gameObject);

            GameManager.instance.CollectKey();
        }
        else if (collision.gameObject.CompareTag(FINISH))
        {
            GameManager.instance.checkLevel = true;

            GameManager.instance.EndGame();
        }
    }
}
