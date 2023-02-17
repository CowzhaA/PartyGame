using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Players;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PersoMort(string Tag)
    {
        if (Players.Length > 1)
        {
            for (int i = 0; i < Players.Length; i++)
            {
                if (Players[i].tag == Tag)
                {
                    //Players[i].enlever ligne
                    Players[i].GetComponent<deplacements>().ModifAffichage();
                }
            }
        }
        else
        {
            Victoire();
        }
    }

    private void Victoire() 
    { 
    
    }
}
