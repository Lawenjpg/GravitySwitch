using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   //rivate int hitpoint = 1;
   //rivate int score = 0;

    public Transform spawnPosition;
    public Transform playerTransform;

    //Every single fram
    private void Update()
    {
        if (playerTransform.position.y < -10)
        {
            playerTransform.position = spawnPosition.position;
            //itpoint--; //hitpoint = hitpoint - 1;
            //if(hitpoint <= 0)
           
            {
                Debug.Log("Failure");
            }
        }
    }
}