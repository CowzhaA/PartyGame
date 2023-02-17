using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionVictoire : MonoBehaviour
{
    public GameManager GameManage;
    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
        GameManage.GetComponent<GameManager>().PersoMort(collider.tag);
        
            
    }
}