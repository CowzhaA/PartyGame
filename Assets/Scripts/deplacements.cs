using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deplacements : MonoBehaviour
{
    public int joueur;
    public Animator myAnim;
    public GameObject AffichageVie;
    public GameObject AffichageMort;
    public GameObject AffichageVictoire;
    public GameManager GameManager;
    public GameObject Moi;
    private Rigidbody rb;
    public bool IsDashing;
    public bool CanDash;
    public float speed;
    public float maxspeed;
    public float dashSpeed;
    public float dashDuration;
    public float dashCoolDown;


    // Start is called before the first frame update
    void Start()
    {
        AjoutPlayer();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (IsDashing)
        {
            return;
        }
        float horizontal = Input.GetAxis("horizontal-joystick" + joueur);
        float vertical = Input.GetAxis("vertical-joystick" + joueur);
        Vector2 mouvement = new Vector2(horizontal, vertical).normalized;
        bool dash = Input.GetButtonDown("Dash"+joueur);

        if (vertical != 0f || horizontal != 0f)
        {
            myAnim.SetBool("isRunning", true);
            rb.AddForce(mouvement.x * Time.deltaTime * speed, 0f, mouvement.y * Time.deltaTime * speed);
            transform.forward = new Vector3(mouvement.x, 0f, mouvement.y);

            if (rb.velocity.magnitude > maxspeed)
            {
                rb.velocity = rb.velocity.normalized * maxspeed;
            }
        }
        else
        {
            myAnim.SetBool("isRunning", false);
        }
        if (dash == true && CanDash == true)
        {
            StartCoroutine(DashInitiate());
            Debug.Log("dash");
        }
        else
        {
            
        }
    }
    private IEnumerator DashInitiate()
    {
        float horizontal = Input.GetAxis("horizontal-joystick" + joueur);
        float vertical = Input.GetAxis("vertical-joystick" + joueur);
        IsDashing = true;
        CanDash = false;
        rb.velocity = dashSpeed * transform.forward;
        yield return new WaitForSeconds(dashDuration);
        IsDashing = false;
        rb.velocity = Vector3.zero;
        yield return new WaitForSeconds(dashCoolDown);
        CanDash = true;
    }

    public void ModifAffichage() 
    {
        AffichageVie.SetActive(false);
        AffichageMort.SetActive(true);
    }

    public void AjoutPlayer()
    {
        GameManager.GetComponent<GameManager>().Players.Add(Moi);
    }

   

    public void Bravo()
    {
        AffichageVictoire.SetActive(true);
        StartCoroutine(WaitOneFrame());
    }

    IEnumerator WaitOneFrame()
    {
        //code
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene(0);
        //code éventuel
    }
}

