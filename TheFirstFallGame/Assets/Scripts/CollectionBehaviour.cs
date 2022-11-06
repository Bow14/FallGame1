using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectionBehaviour : MonoBehaviour
{
    public IntData points;
    public UnityEvent collectionEvent;
    public 
    
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        collectionEvent.Invoke();
        Debug.Log("Ive touched player");
        
    }
}
