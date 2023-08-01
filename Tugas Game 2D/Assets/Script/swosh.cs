using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swosh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void suaraswosh()
    {
        GameObject.Find ("suara swosh").GetComponent<AudioSource> ().Play ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
