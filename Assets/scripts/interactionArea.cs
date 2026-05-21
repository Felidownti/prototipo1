using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionArea : MonoBehaviour
{
    public UIManager UIManagerScript;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }
    void Awake()
    {
        UIManagerScript = GameObject.FindObjectOfType<UIManager>();
    }
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Collectible")){
        Destroy(other.gameObject);
        score  ++;
        UIManagerScript.UpdateScore(score);
       }
    } 
}
