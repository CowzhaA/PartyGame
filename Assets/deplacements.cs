using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal-joystick");
	  Debug.Log("horizontal:"+ horizontal);
        if (horizontal != 0f)
        {
            transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0f, 0f);
        }
            
        float vertical = Input.GetAxis("vertical-joystick");
	  Debug.Log("vertical:"+ vertical);

        if (vertical != 0f)
        {
            transform.position += new Vector3(0f, 0f, -vertical * Time.deltaTime * speed);
        }
            
    }
}
