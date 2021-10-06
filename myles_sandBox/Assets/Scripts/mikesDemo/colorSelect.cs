using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSelect : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    float colorChangeTime;
    [SerializeField]
    Color[] randomColors;
    Color newColor;

    // Update is called once per frame
    void Update()
    {
        ColorChange();
    }

    void ColorChange()
    {

        objRenderer = GetComponent<Renderer>();
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            int randomNum = Random.Range(0, randomColors.Length);
            newColor = randomColors[randomNum];


            objRenderer.material.color = newColor;
            timer = 0;
        }

    }
}      
