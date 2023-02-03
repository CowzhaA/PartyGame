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

    private void OnTriggerEnter()
    {
        compteur = compteur + 1;
    }
}
