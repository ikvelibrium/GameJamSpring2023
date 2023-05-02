using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutomerSpawner : MonoBehaviour
{
    public List<GameObject> customerList = new List<GameObject>();
    public GameObject[] spawnToObject = new GameObject[3];
    
    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        int a = Random.Range(0, spawnToObject.Length);
        GameObject newObject = Instantiate(customerList[Random.Range(0, customerList.Count)], spawnToObject[a].transform.position, Quaternion.identity);
        newObject.transform.SetParent(spawnToObject[a].transform);
    }

}
