using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    public Transform character; // Karakterin Transform bile�eni
    public Transform startPoint; // Yolun ba�lang�� noktas�
    public Transform endPoint; // Yolun biti� noktas�
    public Slider [] progressSlider; // �lerleme durumu i�in slider

    void Update()
    {
        RoadCompletedOnSlider();
    }
    public void RoadCompletedOnSlider()
    {
        // Karakterin ba�lang�� noktas�ndan biti� noktas�na olan ilerlemesini hesapla
        float totalDistance = Vector3.Distance(startPoint.position, endPoint.position);
        float currentDistance = Vector3.Distance(startPoint.position, character.position);

        // �lerlemeyi 0 ile 1 aras�nda normalize et
        float progress = Mathf.Clamp01(currentDistance / totalDistance);

        // Slider'� g�ncelle
        progressSlider[0].value = progress;
        progressSlider[1].value = progress;
    }
}
