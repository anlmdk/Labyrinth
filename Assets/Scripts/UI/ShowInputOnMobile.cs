using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInputOnMobile : MonoBehaviour
{
    void Start()
    {
        // Joystick'i sadece mobile platformda goster

        gameObject.SetActive(Application.isMobilePlatform);    
    }
}
