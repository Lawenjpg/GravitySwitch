using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByBoundary : MonoBehaviour
{
    private void Start()
    {
      GetComponent<Rigidbody>(); 
    }
    void OnTriggerExit(Collider colReport)
    {
        if (colReport.gameObject.CompareTag("Player"))
        {
            Destroy(colReport.gameObject);
        }
       
    }
}