using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float upSpeed;


    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetButton("Fire1"))
            {
                rb.AddForce(new Vector2(0, upSpeed));
            }

        }

    }

}