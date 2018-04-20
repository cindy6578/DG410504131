using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }
    public float speed;
    public GameObject shot;
    public float fireRate;
    public Transform shotSpawn;
    Rigidbody rigidbody;

    float nextFire;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbody.velocity = movement * speed;


    }
}