
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
    public IntData collectionPoints;
    public GameObject player;
    public Vector3 theSpot;
    
    

    
    void Start()
    {
        cameraObj = Camera.main;
        theSpot = new Vector3(-1,-4,0);
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

    public void PlayerMove()
    {
        
        player.transform.position = theSpot;
        //Debug.Log("TheSpot");
        //Debug.Log(player);
        //dragabble = false;   
        
        

    }
    
    // public void OnTriggerEnter(Collider other)
    //  {
    //      Destroy(gameObject);
    //  }

    private void OnTriggerEnter(Collider other)
    {
     
        if (collectionPoints.value < 10 && other.CompareTag("Buildings"))
        {
            
            OnCollisonEvent.Invoke();
        }
     
        
    }

  
}
