using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : MonoBehaviour
{
  public bool powerUpOn;
  public IntData collectionPoints;

  private void OnTriggerEnter(Collider other)
  {
    if ((collectionPoints.value == 10) && (other.gameObject.CompareTag("Vial")))
    {
      powerUpOn = true;
      Debug.Log("I am on");

    }
  }
}
