using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  
    [SerializeField]
    GameObject[] spawnPoint; //populate in unity 
    [SerializeField]
    GameObject prefab; //inptut sphere 
    [SerializeField]
    Material[] mats;  //populate in unity
    Renderer colorRender;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            GameObject item = Instantiate (prefab, spawnPoint[i].transform);  //spawns prefab at spawn point.
            item.GetComponent<Renderer>().material = mats[i]; //assignes material to spaned prefab 



        }

    }
}
