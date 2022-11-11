using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShieldBehaviour : MonoBehaviour
{
  public bool powerUpOn;
  public IntData collectionPoints;
  public UnityEvent shieldCountDown;
  public DraggableBehaviour draggableBehaviour;

  private void OnTriggerEnter(Collider other)
  {
    if ((collectionPoints.value == 9) && (other.gameObject.CompareTag("Vial")))
    {
      powerUpOn = true;
      shieldCountDown.Invoke();
      
      //Debug.Log("I am on");

    }
    else
    {
      draggableBehaviour.OnCollisonEvent.Invoke();
     // powerUpOn = false; 
    }
  }
}
