using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnOff2 : MonoBehaviour {

    public Text textshow = null;
    public void changeWord (string word)
    {
        if (textshow.text == word)
            textshow.text = "OFF";
        else
            textshow.text = word;
    }
}
