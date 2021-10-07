using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]
    GameObject[] SpawnPoints;
    public Material[] recipe;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    bool isRecipe;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SpawnPoints.Length; i++)
        {

            GameObject box = Instantiate(prefab, SpawnPoints[i].transform, false);
            if (isRecipe)
            {
                colorChanger cc = box.GetComponent<colorChanger>();
                int randomNumber = Random.Range(0, cc.materiallist.Length);
                recipe[i] = cc.materiallist[randomNumber];
                box.GetComponent<colorChanger>().indentity = randomNumber;


            }
            else
            {
                box.GetComponent<colorChanger>().indentity = i;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}