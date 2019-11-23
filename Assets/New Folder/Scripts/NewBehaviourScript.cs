//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;



//public class NewBehaviourScript : MonoBehaviour { 
    
//public Transform playerPiece;
//float titleAmount = 1f;
//public Transform hazard, obstacle;
//public Vector3 playerStart;
//public TextMesh playerMsg;
//public Transform[] manyHazards;

//    // Start is called before the first frame update
//    void Start()
//    {
//        playerStart = playerPiece.position;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            print("W key was pressed");

//            Vector3 newPos = playerPiece.position + new Vector3(0f, 0f, titleAmount);
//            newPos += new Vector3(0f, 0f, titleAmount);

           
//                 if (obstacle.position != newPos)

//            playerPiece.position += new Vector3(0f, 0f, titleAmount);

//            if (obstacle.position != playerPiece.position + new Vector3(0f, 0f, titleAmount))
//            {
//                playerPiece.position += new Vector3(0f, 0f, titleAmount);
//            }
//        }
//        if (Input.GetKeyDown(KeyCode.S))
//        {
//            playerPiece.position += new Vector3(0f, 0f, -titleAmount);

//            newPos += new Vector3(0f, 0f, titleAmount);

//    }
//        for(int i = 0; i < manyHazards.Length; i++)
//        {
//            if (manyHazards[i].position == playerPiece.position)
//            {

//            }
         
             

//        }
//        if(hazard.position == playerPiece.position)
//        {
//            playerPiece.position = playerStart;
//        }
//    }

//}
////My idea here is to create a limited amount of enemy, 3 at any time while keeping respawn them. Also to detect the proximity to the player but
////still is not working. I need to figure out how to create these enemies while keeping the summon limit.
////This is the baasic script for one type of enemy