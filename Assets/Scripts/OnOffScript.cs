using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffScript : MonoBehaviour
{

    public Text percentageText;

    void Start()
    {
        percentageText = GetComponent<Text>();
        
    }


    public void textUpdate()
    {
        if (percentageText.text == null)
            percentageText.text = "ON";
        Debug.Log(percentageText.text);
        if (percentageText.text == "ON") {
            Debug.Log("text is ON");
            percentageText.text = "OFF";
        }
        if (percentageText.text == "OFF") {
            Debug.Log("text is OFF");
            percentageText.text = "ON";
        }
    }
}
