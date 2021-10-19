using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    Rigidbody rB;
    [SerializeField]
    float speed = 0.01f;
    [SerializeField]
    float lifeSpan = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.AddForce(Vector3.forward * (speed), ForceMode.Impulse);
     
    }

     //Update is called once per frame
    void Update()
    {
        if (lifeSpan >= 0)
        {
            lifeSpan -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
