using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationHandler : MonoBehaviour
{
    public GameObject portraitPanel;
    public GameObject landscapePanel;

    void Start()
    {
        // Oyun baþladýðýnda telefonun yönüne göre ayarla

        UpdateOrientation();
    }

    void Update()
    {
        UpdateOrientation();
    }

    void UpdateOrientation()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            // Yatay mod

            portraitPanel.SetActive(false);
            landscapePanel.SetActive(true);
        }
        else if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            // Dikey mod

            portraitPanel.SetActive(true);
            landscapePanel.SetActive(false);
        }
    }
}
