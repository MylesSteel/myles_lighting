using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    GameObject objectPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        //spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoints");
        foreach (GameObject spawn in spawnPoints)
        {
            GameObject spawnObject = Instantiate(objectPrefab, spawn.transform, false);
            spawnObject.GetComponent<demoScriptMike>().floatSpeed = Random.Range(1, 5);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
