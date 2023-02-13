using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void EndGame()
    {
        if (compteur >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("END");
        }
    }
}