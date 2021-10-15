using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour
{
    Rigidbody rB;
    float speed = 0.01f;
    float lifeSpan = 1.5f; 

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
        rB.AddForce(Vector3.up * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeSpan >= 0 )
        {
            lifeSpan -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
