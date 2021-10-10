using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  
    [SerializeField]
    GameObject[] spawnPoint;
    [SerializeField]
    GameObject prefab; 
    [SerializeField]
    Material[] mats;
    Renderer colorRender;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            GameObject item = Instantiate(prefab, spawnPoint[i].transform);
            item.GetComponent<Renderer>().material = mats[i];
            


        }
      
    }
}
