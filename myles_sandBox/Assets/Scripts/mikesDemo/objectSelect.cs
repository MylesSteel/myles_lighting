using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSelect : MonoBehaviour
{
        bool isCorrect; 
        private void OnMouseDown()
        {
            if (isCorrect)
            {
                Destroy(this.gameObject);
            }
        }
    
}
