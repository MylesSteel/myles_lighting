using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    
    public Guess gs;           //refrence to guess script to grab public varriables guesses array and guesscount int. 

   // void Start()
    //{
        //gs = GameObject.Find("guessEmpty").GetComponent<Guess>();
   // }





    public void OnMouseDown()
    {
        Debug.Log("clicked");
        gs.guesses[gs.guessCount] = gameObject; //each click on game object is stored in guesses array 
        gs.guessCount++; //increase guesscount by 1 on each click.
        gs.PlayerGuessCheck();  //compares guesses to recipe script gameobject array correctGuess.

    }  //registers input on click



}