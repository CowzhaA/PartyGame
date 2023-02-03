using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{
    private float inputX;
    private float inputY;
    public float speed = 5;
    private float smoothTime = 0.05f;
    private float _currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal-joystick");
        if (horizontal != 0f)
        {
            transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0f, 0f);
        }
            
        float vertical = Input.GetAxis("vertical-joystick");

        if (vertical != 0f)
        {
            transform.position += new Vector3(0f, 0f, -vertical * Time.deltaTime * speed);
        }
            
        var targetAngle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
        var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, - targetAngle, ref _currentVelocity, smoothTime);
        transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);


    }
}
