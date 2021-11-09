using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SnapShotCollieder : MonoBehaviour
{
    public AudioMixerSnapshot day;
    public AudioMixerSnapshot night;

    bool isNight = false;

    public AudioMixer audioMixer;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!isNight) 
            {
              night.TransitionTo(0.5f);
              isNight = true;
            }
            else 
            {
              day.TransitionTo(0.5f);
              isNight = false;
            }

        }
      
    }

}
