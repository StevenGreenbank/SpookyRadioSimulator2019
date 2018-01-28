using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineListener : MonoBehaviour {


    float time = 50;
    int volume = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public float GetTime()
    {
        return time;
    }

    public int GetVolume()
    {
        return volume;
    }



}
