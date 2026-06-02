using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.ItemRecolectado();
        }
    }
}