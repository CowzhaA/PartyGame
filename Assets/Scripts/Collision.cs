using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int force;

    private void OnCollisionEnter(UnityEngine.Collision c)
    {
        if (c.gameObject.layer == 3)
        {
            c.gameObject.GetComponent<Rigidbody>().AddForce(c.contacts[0].normal * force);
        }
    }
}
