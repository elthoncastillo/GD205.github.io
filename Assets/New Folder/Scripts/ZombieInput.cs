using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieInput : MonoBehaviour
{
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnim.SetInteger("AnimState", 1);
        }
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            myAnim.SetInteger("AnimState", 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myAnim.SetInteger("AnimState", 3);
        }
    }
}
