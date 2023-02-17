using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int force;

    private void OnCollisionEnter(UnityEngine.Collision c)
    {
        if (c.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Vector3 dir = c.transform.position - transform.position;
            dir = dir.normalized;
            c.gameObject.GetComponent<Rigidbody>().AddForce(dir * force);
        }
    }
}
