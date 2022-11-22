using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectionBehaviour : MonoBehaviour
{
    public IntData points;
    public UnityEvent collectionEvent;
    public IntData collectionPoints;
    public UnityEvent shieldEvent;
    public GameObject player;



    
    
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        collectionEvent.Invoke();
        Debug.Log("Ive touched player");
        
        // if (other.gameObject.CompareTag("Vial"))
        // {
        //     shieldEvent.Invoke();
        // }
        
        if (collectionPoints.value == 10)
        {
           // shieldEvent.Invoke(); //Gotta make it where the shieldevent last longer than a second
            
        }



    }
}
