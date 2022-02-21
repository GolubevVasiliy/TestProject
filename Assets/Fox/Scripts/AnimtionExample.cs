using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimtionExample : MonoBehaviour
{
    private Animator animFox;
    // Start is called before the first frame update
    void Start()
    {
        animFox = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //press the "A" button to play the "run" animation
        if (Input.GetKeyDown(KeyCode.A))
        {
            animFox.SetBool("Run_Bool", true);
            animFox.SetBool("Walk_Bool", false);
            animFox.SetBool("Idle_Bool", false);
        }
        //press the "S" button to play the "walk" animation
        if (Input.GetKeyDown(KeyCode.S))
        {
            animFox.SetBool("Walk_Bool", true);
            animFox.SetBool("Run_Bool", false);
            animFox.SetBool("Idle_Bool", false);
        }
        //press the "D" button to play the "idle" animation
        if (Input.GetKeyDown(KeyCode.D))
        {
            animFox.SetBool("Idle_Bool", true);
            animFox.SetBool("Run_Bool", false);
            animFox.SetBool("Walk_Bool", false);
            
        }
    }
}
