using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorList : MonoBehaviour
{
    [SerializeField]
    Material[] materiallist;
    Renderer colorRenderer;
    public int identity;

    // Start is called before the first frame update
    void Start()
    {
        colorRenderer = GetComponent<Renderer>();
        colorRenderer.sharedMaterial = materiallist[identity];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
