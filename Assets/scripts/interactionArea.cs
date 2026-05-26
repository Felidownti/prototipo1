using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionArea : MonoBehaviour
{
    public UIManager UIManagerScript;
    public int score = 0;

    void Awake()
    {
        UIManagerScript = GameObject.FindObjectOfType<UIManager>();
    }

    void Start()
    {
        UIManagerScript.UpdateScore(0); // ahora sí llama al método correcto
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectible")){
            Destroy(other.gameObject);
            score++;
            UIManagerScript.UpdateScore(score);
        }
    }
}
