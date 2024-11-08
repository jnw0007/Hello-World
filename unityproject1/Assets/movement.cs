using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.forward * 100);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.rotation = (Quaternion.Euler(0, 1 + rb.rotation.eulerAngles.y,0));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(transform.forward * -100);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.rotation = (Quaternion.Euler(0, -1 + rb.rotation.eulerAngles.y, 0));
        }
    }
}
