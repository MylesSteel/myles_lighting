using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float timeValue = 60; 

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
            {
            timeValue -= Time.deltaTime; 
        }
        else
        {
            timeValue += 60; 
        }
        
    }
}

 