using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int timeValue = 60;
    public bool takingAway1 = false;
    // Update is called once per frame

    private void Start()
    {
        textDisplay.GetComponent<Text>().text = "" + timeValue;
    }
    void Update()
    {
        if (takingAway1 == false && timeValue > 0)
        {
            StartCoroutine(timerDown());
        }
        IEnumerator timerDown()
        {
            takingAway1 = true;
            yield return new WaitForSeconds(1);
            timeValue -= 1;
            textDisplay.GetComponent<Text>().text = "" + timeValue;
            takingAway1 = false;
        }

    }

}
