using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{
    private float inputX;
    private float inputY;
    public float speed = 5;
    private float smoothTime = 0.05f;
    public int joueur;
    private float _currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal-joystick"+joueur);
        if (horizontal != 0f)
        {
            transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0f, 0f);
            transform.forward += new Vector3(horizontal * Time.deltaTime * speed, 0f, 0f);
        }
            
        float vertical = Input.GetAxis("vertical-joystick"+joueur);

        if (vertical != 0f)
        {
            transform.position += new Vector3(0f, 0f, -vertical * Time.deltaTime * speed);
            transform.forward += new Vector3(0f, 0f, -vertical * Time.deltaTime * (speed*5));
        }
            


    }
}
