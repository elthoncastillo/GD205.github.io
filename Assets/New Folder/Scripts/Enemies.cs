//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class Enemies : MonoBehaviour
//{
//    public float speed;
//    public float position;
//    private bool moving = true;

//    public Transform detection;


//    // Start is called before the first frame update
//    void Update()
//    {
//        transform.Translate(Vector3.right * speed * Time.deltaTime);

//        RaycastHit groundInfo = Physics.Raycast(detection.position, Vector3.down, position);
//        if (groundInfo.collider == false)
//        {
//            if (moving == true)
//            {
//                transform.eulerAngles = new Vector3(0, 180, 0);
//                moving = false;
//            }
//            else
//            {
//                transform.eulerAngles = new Vector3(0, 0, 0);
//                moving = true;
//            }
//        }

//    }
//}



////scriot modified of Blackthornprod
////Link of his video: https://www.youtube.com/watch?v=aRxuKoJH9Y0