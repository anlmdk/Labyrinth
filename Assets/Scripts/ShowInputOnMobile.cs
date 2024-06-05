using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInputOnMobile : MonoBehaviour
{
    void Start()
    {
        // Input button show just on mobile

        gameObject.SetActive(Application.isMobilePlatform);    
    }
}
