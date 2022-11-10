
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    //    //AnthonyRomrell Module  Matching game 1 code

    public ShieldBehaviour powerUp;
    private Camera cameraObj;
    public bool dragabble;
    public Vector3 position;
    public Vector3 offSet;
    public UnityEvent startDragEvent, endDragEvent, OnCollisonEvent;
    public UnityEvent shieldEvent;
    
    void Start()
    {
        cameraObj = Camera.main;
        //Physics.IgnoreLayerCollision(0, 8);
    }

    public IEnumerator OnMouseDown()
    {
        offSet = transform.position -cameraObj.ScreenToWorldPoint(Input.mousePosition);
        dragabble = true;
        startDragEvent.Invoke();
        
        yield return new WaitForFixedUpdate();


        while (dragabble)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offSet;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        dragabble = false;
        endDragEvent.Invoke();
    }
    
    // public void OnTriggerEnter(Collider other)
    //  {
    //      Destroy(gameObject);
    //  }

    private void OnCollisionEnter(Collision other)
    {
        
         if (powerUp.powerUpOn == true)
         {
             shieldEvent.Invoke();
             
         }

         if (powerUp.powerUpOn == false)
         {
             OnCollisonEvent.Invoke();
         }
        
    }
}
