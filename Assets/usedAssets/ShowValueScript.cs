using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValueScript : MonoBehaviour {

    Text percentageText;
    int percentage;


	void Start () {
        percentageText = GetComponent<Text> ();
	}
	

	public void textUpdate (float value) {

        percentage = Mathf.RoundToInt(value * 100);
        percentageText.text = percentage + "%";
	}
}
