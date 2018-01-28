using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainScript : MonoBehaviour {
    bool CutCallPressed = false;
    bool PlayAdPressed = false;
    float slideValue = 80f;
	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("" + CutCallPressed + " " + PlayAdPressed + 
            " " + slideValue);
        if (CutCallPressed) {
            CutCallPressed = false;
        }
        if (PlayAdPressed) {
            PlayAdPressed = false;
        }

    }

    public void slideUpdate(float value) {
        slideValue = value;
    }

    public void CutCall()
    {
        CutCallPressed = true; 
    }
    public void PlayAd()
    {
        PlayAdPressed = true; 
    }
}
