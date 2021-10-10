using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
    
    public guessLogic gl;

    // Start is called before the first frame update
    void Start()
    {
        gl = GameObject.Find("spawn").GetComponent<guessLogic>(); //finds game logic script userguess array 
    }
    public void OnMouseDown() // checks user guess on each inpput 
    {
        gl.userGuess[gl.guessCount] = gameObject;
        gl.guessCount++;  
        gl.answerCheck();
        
    }
}
