using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
    
    private guessLogic gl;

    // Start is called before the first frame update
    void Start()
    {
        gl = GameObject.Find("gl").GetComponent<guessLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        gl.userGuess[gl.guessCount] = gameObject;
        gl.guessCount++;
        gl.answerCheck(); 
    }
}
