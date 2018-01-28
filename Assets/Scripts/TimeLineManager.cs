using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class TimelineManager : MonoBehaviour {

    // slider listeners ### set type, init, etc
<<<<<<< Updated upstream
    //TimelineListener TLQListener;
=======
   // TimelineListener TLQListener;
>>>>>>> Stashed changes
   

    // timeline queues
    TimelineQueue TLQ;
    int currentSection;

    // Use this for initialization
    public void Init()
    {
        currentSection = 0;



    }

    // Update is called once per frame
    void Update () {

        //get timelime cues from listeners


        // compare times to timelines, update if nessecary

        // if volumes don't match

        /*
        if (!CompareVolume(TLQ, TLQListener))
        {
            StopAndPunish();
        }


        else {
            // else, adjust ratings and oxygen as normal


        }
        */










    }


    public void ClearAllTimelineQueues()
    {
        TLQ.Clear();
 
    }



    /*
    private bool AfterEnd()
    {
        return TLQListener.getTime() >= TLQ.Peek().timeEnd;
    }    

    private bool CompareVolume()
    {
        return TLQListener.getVolume() == TLQ.Peek().volume; 
    }

    */

    private void StopAndPunish()
    {
        // stop clips


        // punish player


        // move current section to next section
        currentSection++;
        TLQ.NextSection();


        // clear timelines
        ClearAllTimelineQueues();

        //and fill them with the next section's timelines
        FillQueue();


    }

    //init and upadte section before using
    private void FillQueue()
    {
        // need a var to store the clip lengths, 


        for (int i = 0; i < soundCues.SectionLength(currentSection); i++)
        {
            TLQ.Enqueue(soundCues.GetCue(currentSection, i));

        }


    }



}
*/