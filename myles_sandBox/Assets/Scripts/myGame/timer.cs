using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timeValue = 60;
    public Text timerText;
    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
            {
            timeValue -= Time.deltaTime; 
        }
        else
        {
            timeValue = 0; 
        }
        
    }

    void DisplayTime(float time)
    {
        if(time < 0 )
        {
            time = 0; 
        }
        float seconds = Mathf.FloorToInt(time % 60);

        timerText.text = string.Format("{0:00}", seconds);
    }

}

 