using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessLogic : MonoBehaviour
{
    
    public recipeSpawn rS;

    public GameObject[] userGuess;
    public int guessCount = 0;

   
    public void answerCheck()
    {
        if (guessCount == userGuess.Length -1)
        {
            for (int i = 0; i < userGuess.Length; i++)
            {
                if (userGuess[i] == rS.correctAnswer[i])
                {
                    
                }
                else
                {

                }

            }
        }
        

 

        
    }
}
