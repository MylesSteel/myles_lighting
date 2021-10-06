using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour

{
    //System.Random random = new System.Random();
    public Material[] materiallist;
    //public int[] materialList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    public int indentity;
    public Color[] randomColor; 
    Color newColor;
    Renderer objRenderer;
    public Material Red;

    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        objRenderer.sharedMaterial = materiallist[indentity];
        //change renderer = materiallist[identity]


        //materialList[0] = 9;

    }

    // Update is called once per frame
    void Update()
    {
        //  objRenderer = GetComponent<Renderer>();
        // int random = Random.Range(0, randomColor.Length);
        // newColor = randomColor[random];
    }
}