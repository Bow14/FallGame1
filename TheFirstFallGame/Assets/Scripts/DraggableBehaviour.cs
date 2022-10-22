
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    //    //AnthonyRomrell Module  Matching game 1 code

    
    private Camera cameraObj;
    public bool dragabble;
    public Vector3 position;
    public Vector3 offSet;
    public UnityEvent startDragEvent, endDragEvent, OnCollisonEvent;
    
    void Start()
    {
        cameraObj = Camera.main;
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

    private void OnCollisionEnter(Collision collision)
    {
        OnCollisonEvent.Invoke();
    }
}
