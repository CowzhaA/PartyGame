/*using System.Collections;
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

    Animator Animation;
    public bool run;
    public Animator myAnim;

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        Animation = gameObject.AddComponent<Animator>();
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal-joystick" + joueur);
        float vertical = Input.GetAxis("vertical-joystick" + joueur);
        if (vertical !=0 || horizontal !=0)
        {
            run = true;
            transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0f, -vertical * Time.deltaTime * speed);
            transform.forward += new Vector3(horizontal * Time.deltaTime * (speed * 5), 0f, -vertical * Time.deltaTime * (speed * 5));
        }

        Animation.SetBool("run", run);

        
        /*float Horizontal = Input.GetAxis("horizontal-joystick" + joueur );
        float Vertical = Input.GetAxis("vertical-joystick" + joueur );

        Vector3 mouvement = new Vector3(Horizontal, 0, Vertical);
        m_Rigidbody.AddForce(mouvement * speed * Time.deltaTime);
        
    }
} */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deplacements : MonoBehaviour
{
    public int joueur;
    Animator m_Animator;
    public Animator myAnim;
    public bool run;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 2;
        float horizontal = Input.GetAxis("horizontal-joystick" + joueur);
        float vertical = Input.GetAxis("vertical-joystick" + joueur);


        if (Mathf.Abs(vertical) >= 0.2f)
        {
            run = true;
            transform.position += new Vector3(speed * horizontal * Time.deltaTime, 0f, speed * vertical * Time.deltaTime);
            transform.forward = new Vector3(speed * horizontal * Time.deltaTime, 0f, speed * vertical * Time.deltaTime);
        }
        else if (Mathf.Abs(horizontal) >= 0.2f)
        {
            run = true;
            transform.position += new Vector3(speed * horizontal * Time.deltaTime, 0f, speed * vertical * Time.deltaTime);
            transform.forward = new Vector3(speed * horizontal * Time.deltaTime, 0f, speed * -vertical * Time.deltaTime);
        }
        else
        {
            run = false;
        }
        m_Animator.SetBool("run", run);
    }
}