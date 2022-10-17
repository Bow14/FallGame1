using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancerSpawn : MonoBehaviour
{

    public GameObject[] prefabbedData;
    public Vector3Data spawnPos;
    

    public void Spawnrandom()
    {
        int obstacal = Random.Range(0, prefabbedData.Length);
        Instantiate(prefabbedData[obstacal]);
        
    }

    // public void StartSpawning()
    // {
    //     InvokeRepeating("Spawnrandom");
    // }
    private IEnumerator StartSpawning()
    {
        Spawnrandom();
        yield return prefabbedData;
    }
   
}
