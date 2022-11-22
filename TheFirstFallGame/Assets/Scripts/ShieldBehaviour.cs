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
  public TimerScript calling;

  public void OnTriggerEnter(Collider other)
  {
    if ((collectionPoints.value >= 10) && (other.CompareTag("Vial")))
    {
      powerUpOn = true;
      //shieldCountDown.Invoke();
      calling.CallingShieldCount();
      
      //Debug.Log("I am on");

    }
    else
    {
      //draggableBehaviour.OnCollisonEvent.Invoke();
     // powerUpOn = false; 
    }
  }
}
