using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Players;
    public GameObject AfficheV;
    public void PersoMort(string Tag)
    {
       
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].tag == Tag)
                {
                   
                    Players[i].GetComponent<deplacements>().ModifAffichage();
                    Players.RemoveAt(i) ;
                    
                    
                }
            }

        if (Players.Count < 2)
        {
            
            Victoire();
        }
    }

    private void Victoire()
    {
        AfficheV.SetActive(true);
        for(int i = 0; i < Players.Count; i++)
        {       
                Players[i].GetComponent<deplacements>().Bravo();
                
        }
    }
}
