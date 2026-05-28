using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textPuntos;
    public TextMeshProUGUI textTiempo;

    void Start()
    {
        UpdateScore(0);
    }

    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    void Update()
    {
        txtTiempo.text = Time.time.ToString
    }
}