using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class move : MonoBehaviour
{

    Rigidbody rb;


   
    
    public float speed;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();

   
    }

    // Update is called once per frame
    void Update()
    {

        float z = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");
        //transform.Translate(x, 0, z);

        rb.AddForce(new Vector3(x, 0, z) * speed);



       


    }

   
    

}