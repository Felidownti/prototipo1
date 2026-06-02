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
        textPuntos.text = "puntos: " + score.ToString();
    }

    public void UpdateTiempo(float tiempo)
    {
        textTiempo.text = "tiempo: " + tiempo.ToString("F2");
    }
}