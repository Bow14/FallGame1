using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PrefabData : ScriptableObject
{
  public GameObject prefab;

  public List<PrefabData> preFabListList;

  public Transform trans;
}
