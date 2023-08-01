using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorakhir : MonoBehaviour
{
    public GameObject skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "skor akhir")
        {
            GetComponent<Text> ().text = skor.GetComponent<skor> ().score.ToString ();
        } else if (gameObject.name == "highscore")
        {
            int HS = PlayerPrefs.GetInt ("highscore");
            GetComponent<Text> ().text = HS.ToString();
        }
    }
}
