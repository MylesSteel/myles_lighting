using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipe : MonoBehaviour
{
    [SerializeField]
    GameObject[] ingredients;  //array from ingredints
    [SerializeField]
    GameObject[] spawnPoint;  //array for spawn empty/location.

    public GameObject[] correctAnswer; //populate array in unity engine     correctAnswer=recipe on mikes demo

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoint.Length; i++) //populate array
        {
            int randNum = Random.Range(0, spawnPoint.Length); //selects random object from ingredients array
            GameObject item = Instantiate(ingredients[randNum], spawnPoint[i].transform); //spawns ingredient at random from ingredients array at spawn point.
            correctAnswer[i] = item;

        }
    }

}
