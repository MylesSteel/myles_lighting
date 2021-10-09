using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipeSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnPointRecipe;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    Material[] mats;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPointRecipe.Length; i++)
        {
            GameObject item = Instantiate(prefab, spawnPointRecipe[i].transform);
            int randNum = Random.Range(0, spawnPointRecipe.Length);
            item.GetComponent<Renderer>().material = mats[randNum];
        }
    }
}
