using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoScriptMike : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    float colorChangeTime;
    float yPos;
    [SerializeField]
    [Range(0, 5)]
    float yRange;
    public float floatSpeed;
    [SerializeField]
    bool isCorrect;
    [SerializeField]
    Color[] randomColors;
    Color newColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objRenderer = GetComponent<Renderer>();
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            int randomNum = Random.Range(0, randomColors.Length);

            //Debug.Log("interval" + colorChangeTime);
        
                newColor = randomColors[randomNum];
            
          
            objRenderer.material.color = newColor;
            timer = 0;
        }
        yPos = Mathf.PingPong(Time.time * floatSpeed, 1) * yRange;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
    private void OnMouseDown()
    {
        if (isCorrect)
        {
            Destroy(this.gameObject);
        }
    }
}
