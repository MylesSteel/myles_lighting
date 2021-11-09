using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class SnapShotManager : MonoBehaviour
{
    public AudioMixerSnapshot day;
    public AudioMixerSnapshot night;

    //public AudioMixer ambience;
   // public AudioMixerGroup birds;

    public float transitionTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnPlayAudio()                      //play populated audio source
    {
        night.TransitionTo(transitionTime);           //transition operator 
        day.TransitionTo(transitionTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
