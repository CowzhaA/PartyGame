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
using Unity.VisualScripting;
using UnityEngine;


public class deplacements : MonoBehaviour
{
    public int joueur;
    public Animator myAnim;
    public GameObject AffichageVie;
    public GameObject AffichageMort;
    public GameManager GameManager;
    public GameObject Moi;
    private Rigidbody rb;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        AjoutPlayer();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal-joystick" + joueur);
        //Debug.Log(horizontal);
        float vertical = Input.GetAxis("vertical-joystick" + joueur);
        Vector2 mouvement = new Vector2(horizontal, vertical);

        if (vertical != 0f || horizontal != 0f)
        {
            myAnim.SetBool("isRunning", true);
            rb.AddForce(mouvement.x * Time.deltaTime * speed, 0f, mouvement.y * Time.deltaTime * speed);
            transform.forward = new Vector3(mouvement.x, 0f, mouvement.y);

        }
        else
        {
            myAnim.SetBool("isRunning", false);
        }
        
    }

    public void ModifAffichage() 
    {
        AffichageVie.SetActive(false);
        AffichageMort.SetActive(true);
    }

    public void AjoutPlayer()
    {
        //GameManager.GetComponent<GameManager>().Players.AddRange();
    }
}