using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnPoint;
    [SerializeField]
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
            Instantiate(prefab, spawnPoint[i].transform );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
