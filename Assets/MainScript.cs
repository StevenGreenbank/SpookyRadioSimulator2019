using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainScript : MonoBehaviour
{
    AudioManager a;
    Sound mainSoundTrack;
    bool PlayAdPressed = false;
    float slideValue = 0f;
    bool singleton = false;
    bool CutCallPressed = true;
    float[] hotPoints;
    string[] branchNames = { "Reward 1", "Reward 2" };
    class hotPoint
    {
        public float start;
        public float end;
        public int index;
        public float volume;
        public bool gt;
        public bool cutCall;
        public bool playAd;
        public hotPoint(float start, float end, int index, float volume, bool gt, bool cutCall, bool playAd)
        {
            this.start = start;
            this.end = end;
            this.index = index;
            this.volume = volume;
            this.gt = gt;
            this.cutCall = cutCall;
            this.playAd = playAd;
        }
    }
    static hotPoint[] h =
        new hotPoint[] {
            new hotPoint ( 30f,  59f,  1, -1f, true,   true,false),
            new hotPoint ( 65f,  84f,  1, -1f, true,   false,true)
        };

    // Use this for initialization
    void Start()
    {
        a = FindObjectOfType<AudioManager>();
        mainSoundTrack = a.returnSound("Tutorial");
        a.Play("Tutorial");
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime;
        if (!singleton)
        {
            currentTime = a.GetSoundTimeSeconds("Tutorial");
            hotPoint c = Array.Find(h, point => point.start <= currentTime && point.end >= currentTime);
            if (c == null)
            {
                CutCallPressed = false;
                PlayAdPressed = false;
                return;
            }
            if ((c.cutCall && CutCallPressed) || (c.playAd && PlayAdPressed))
            {
                StartCoroutine(branchEvent(c.end, branchNames[c.index]));
            }
        }

    }


    public void slideUpdate(float value)
    {
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


    IEnumerator branchEvent(float skipTo, string trackName)
    {
        singleton = true;
        a.PauseSound("Tutorial");
        a.SeekInSeconds("Tutorial", skipTo);
        a.Play(trackName);
        yield return new WaitForSeconds(a.returnSound(trackName).source.clip.length);
        singleton = false;
        a.Play("Tutorial");
    }
}
