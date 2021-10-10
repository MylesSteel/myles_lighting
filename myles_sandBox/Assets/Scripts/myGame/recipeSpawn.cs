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
    public GameObject[] correctAnswer; //elements must be populated in Engine 
   

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPointRecipe.Length; i++) //populate array
        {
            GameObject item = Instantiate(prefab, spawnPointRecipe[i].transform); //spawns prefab at spawn point
            int randNum = Random.Range(0, spawnPointRecipe.Length); //selects random prefab that has been spawned 
            item.GetComponent<Renderer>().material = mats[randNum]; //gets materials for randNum int
            correctAnswer[i] = prefab; //populates correct answer array with prefabs in order. They are all the same prefab but the elements are in order so i beleive this works. 
        }
    }
}

