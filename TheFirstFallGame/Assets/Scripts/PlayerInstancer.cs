using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerInstancer : ScriptableObject
{
    public GameObject playerPrefab;
    
    public void CreateInstance()
    {
        Instantiate(playerPrefab);
    }
    public void CreateInstance(Vector3Data obj )
    {
        Instantiate(playerPrefab, obj.value, Quaternion.identity);
        //Quaternion is a way of rotation but for this its keeping its values 0
    }
}
