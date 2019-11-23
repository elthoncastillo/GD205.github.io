using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phycicsMove : MonoBehaviour
{
    Rigidbody rb;
    public float forceAmt = 25f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0f, 0f, 1f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0f, 0f, -1f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-1f, 0f, 0f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(+1f, 0f, 0f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(new Vector3(0f, 1f, 0f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddForce(new Vector3(0f, -1f, 0f) * forceAmt);
        }
    }
      /*  void OnCollisionEnter(Collision colReport)
        {
            if (colReport.gameObject.CompareTag("Collectible")) ;
            Destroy(colReport.gameObject);
        } */

 }

