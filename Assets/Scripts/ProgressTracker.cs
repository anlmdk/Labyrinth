using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    public Transform character; // Karakterin Transform bileþeni
    public Transform startPoint; // Yolun baþlangýç noktasý
    public Transform endPoint; // Yolun bitiþ noktasý
    public Slider [] progressSlider; // Ýlerleme durumu için slider

    void Update()
    {
        RoadCompletedOnSlider();
    }
    public void RoadCompletedOnSlider()
    {
        // Karakterin baþlangýç noktasýndan bitiþ noktasýna olan ilerlemesini hesapla
        float totalDistance = Vector3.Distance(startPoint.position, endPoint.position);
        float currentDistance = Vector3.Distance(startPoint.position, character.position);

        // Ýlerlemeyi 0 ile 1 arasýnda normalize et
        float progress = Mathf.Clamp01(currentDistance / totalDistance);

        // Slider'ý güncelle
        progressSlider[0].value = progress;
        progressSlider[1].value = progress;
    }
}
