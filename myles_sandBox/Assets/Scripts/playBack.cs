using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class playBack : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource; 

    // Update is called once per frame
    void Update()
    {



    }
    void OnFire()
    {
         audioSource.Play();
    }
    void OnPlayAudio()
    {
        audioSource.Play(); 

    }
}
