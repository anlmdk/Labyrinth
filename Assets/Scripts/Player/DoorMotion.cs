using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public GameObject[] door;

    private void Update()
    {
        DoorInteractive();
    }

    public void DoorInteractive()
    {
        // Kapý görsellerini aktif etme veya deaktif etme

        if (GameManager.instance.checkKey is true)
        {
            door[0].SetActive(true);
            door[1].SetActive(true);
            door[2].SetActive(false);
        }
        else
        {
            door[0].SetActive(false);
            door[1].SetActive(false);
            door[2].SetActive(true);
        }
    }
}
