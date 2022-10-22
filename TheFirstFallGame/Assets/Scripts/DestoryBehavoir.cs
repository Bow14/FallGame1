using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestoryBehavoir : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsObj;
    //public UnityEvent destroeyed;

    private IEnumerator Start()
     {
         wfsObj = new WaitForSeconds(seconds);
         yield return wfsObj;
         Destroy(gameObject);
     }

    // public void OnTriggerEnter(Collider other)
    // {
    //     destroeyed.Invoke();
    //     Destroy(gameObject);
    // }
}
