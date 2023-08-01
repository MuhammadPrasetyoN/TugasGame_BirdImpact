using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeCopy : MonoBehaviour
{
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void copy()
    {
        Instantiate (pipe, transform.position, transform.rotation);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
