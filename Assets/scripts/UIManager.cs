using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textPuntos;
    public TextMeshProUGUI textTiempo;

    [Header("Paneles de resultado")]
    public GameObject panelGanaste;
    public GameObject panelPerdiste;

    void Start()
    {
        UpdateScore(0);

        if (panelGanaste != null) panelGanaste.SetActive(false);
        if (panelPerdiste != null) panelPerdiste.SetActive(false);
    }

    public void UpdateScore(int score)
    {
        textPuntos.text = "puntos: " + score.ToString();
    }

    public void UpdateTiempo(float tiempo)
    {
        textTiempo.text = "tiempo: " + tiempo.ToString("F2");
    }

    public void MostrarResultado(bool gano)
    {
        if (gano)
        {
            if (panelGanaste != null) panelGanaste.SetActive(true);
        }
        else
        {
            if (panelPerdiste != null) panelPerdiste.SetActive(true);
        }
    }
}