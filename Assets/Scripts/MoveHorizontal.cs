using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveHorizontal : MonoBehaviour
{
    public float speed = 5.0f;
    public float xLeftRange = -0.5f;
    public float xRightRange = 2.8f;
    public FixedJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        transform.Translate(Vector3.right * Time.deltaTime * speed * joystick.Horizontal);
    }
    void FixedUpdate()
    {
   
    }
    void LateUpdate()
    {
        if (transform.position.x < xLeftRange)
        {
            transform.position = new Vector3(xLeftRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRightRange)
        {
            transform.position = new Vector3(xRightRange, transform.position.y, transform.position.z);
        }
    }


}

