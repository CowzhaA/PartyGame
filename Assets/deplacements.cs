using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{
    public float speed = 5;
    public int joueur;
    private float currentVelocity;

    public float dashspeed;
    public float dashtime;
    public float dashCooldown;

    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal-joystick" + joueur);
        if (horizontal != 0f)
        {
            transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0f, 0f);
            transform.forward += new Vector3(horizontal * Time.deltaTime * speed, 0f, 0f);
        }

        float vertical = Input.GetAxis("vertical-joystick" + joueur);

        if (vertical != 0f)
        {
            transform.position += new Vector3(0f, 0f, -vertical * Time.deltaTime * speed);
            transform.forward += new Vector3(0f, 0f, -vertical * Time.deltaTime * (speed * 5));
        }
        
        /*float Horizontal = Input.GetAxis("horizontal-joystick" + joueur );
        float Vertical = Input.GetAxis("vertical-joystick" + joueur );

        Vector3 mouvement = new Vector3(Horizontal, 0, Vertical);
        m_Rigidbody.AddForce(mouvement * speed * Time.deltaTime);
        */
    }
}
