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

    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
        //if (collider.gameObject.tag == "Player")
        //{
            compteur = compteur + 1;
            Debug.Log("MORT");
       // }
    }

    public void EndGame()
    {
        if (compteur > 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("END");
        }
    }
}