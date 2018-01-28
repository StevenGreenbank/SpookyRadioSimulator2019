using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class TimelineManager : MonoBehaviour {

    // slider listeners ### set type, init, etc

   // TimelineListener TLQListener;
   

    // timeline queues
    TimelineQueue TLQ;
    int currentSection;

    SoundCues soundCues;
    string currentClipName;
    Time currentTime;



    // Use this for initialization
    public void Init()
    {
        currentSection = 0;
        currentClipName = soundCues.GetClipName(currentSection);
        FillQueue();

    }

    // Update is called once per frame
    void Update () {

        //get timelime cues from listeners
        currentTime = instance.GetSoundTime(currentClipName);


        // compare times to timelines, update if nessecary
        if(AfterEnd())
        {

            if (!TLQ.IsEmpty())
            {
                TLQ.Next(); 
            }
            else
            { 
                  SetNextSectionSeq();
            }
        }


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
       instance.Stop(currentClipName);

    // punish player


        SetNextSectionSeq();


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


    private void StartSound()
    {
        instance.Play(currentClipName);   
    }


    private void SetNextSectionSeq()
    {
         if (soundCues.MAX_SECTIONS != currentSection - 1)
         {

             // queue up next section
            currentSection++;
            TLQ.NextSection();
            // clear timelines
            ClearAllTimelineQueues();
            //and fill them with the next section's timelines
            FillQueue();


        }
        else
        {
               // cue endgame sequence
        }



    
}




}
*/