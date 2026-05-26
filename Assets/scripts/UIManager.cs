using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;

    void Start()
    {
        UpdateScore(0);
    }

    public void UpdateScore(int score)
    {
        txtScore.text = "puntos: " + score.ToString();
    }

    void Update()
    {
        
    }
}