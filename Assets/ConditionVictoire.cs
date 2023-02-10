using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionVictoire : MonoBehaviour
{
    int compteur;
    void Start()
    {
        compteur = 0;
    }

    private void OnCollisionEnter()
    {
        compteur = compteur + 1;
        Destroy(gameObject);
        Debug.Log("MORT");
    }
}
