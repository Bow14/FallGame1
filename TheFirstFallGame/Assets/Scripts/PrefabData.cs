using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PrefabData : ScriptableObject
{
  public GameObject[] prefabs;

  public List<PrefabData> preFabListList;

  public Transform trans;
}
