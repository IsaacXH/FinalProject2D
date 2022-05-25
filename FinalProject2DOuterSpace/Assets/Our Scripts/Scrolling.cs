using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{

    private Rigidbody2D rb2d;
    

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();


        rb2d.velocity = new Vector2(-1.5f, 0);
    }

    void Update()
    {
        

        if (PlayerController.instance.isdead == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
