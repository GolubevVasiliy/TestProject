using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutBounds : MonoBehaviour
{
    public static bool gameOver = false;
    public float topBound = 10.0f;
    public float lowerBound = 1.0f;
   // private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
             gameOver = true;
              Debug.Log("Game Over!");
             Destroy(gameObject);
        }
    }
  }