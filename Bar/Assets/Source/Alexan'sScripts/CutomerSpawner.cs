using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutomerSpawner : MonoBehaviour
{
    public List<GameObject> customerList = new List<GameObject>();
    public GameObject[] spawnToObject = new GameObject[3];
    
    void Start()
    {
        Instantiate(customerList[Random.Range(0, customerList.Count)], spawnToObject[Random.Range(0, spawnToObject.Length)].transform.position, Quaternion.identity);
    }

}
