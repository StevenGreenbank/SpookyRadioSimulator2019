using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour {

    // slider listeners ### set type, init, etc

    TimelineListener TLQListener;
    const int RATINGS_LOSS = 10;
    AudioManager audioMan;
    PlayerStats playerStats;


    //dummy functions


    // timeline queues
    TimelineQueue TLQ;
    int currentSection;

    SoundCues soundCues;
    string currentClipName;
    float currentTime;



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
        currentTime = audioMan.GetSoundTime(currentClipName);


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

        
        if (!CompareVolume())
        {
            StopAndPunish();
        }


        else {
            // else, adjust ratings and oxygen as normal
            playerStats.LeakO2();
            playerStats.GainRatings();

        }
    }


    public void ClearAllTimelineQueues()
    {
        TLQ.Clear();
 
    }




    private bool AfterEnd()
    {
        return TLQListener.GetTime() >= TLQ.Peek().timeEnd;
    }    




    private bool CompareVolume()
    {
        return TLQListener.GetVolume() == TLQ.Peek().volume; 
    }



    private void StopAndPunish()
    {
        // stop clips
        audioMan.Stop(currentClipName);

        // punish player
        playerStats.PunishO2();
        playerStats.LoseRatings(currentSection * RATINGS_LOSS);

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
        audioMan.Play(currentClipName);   
    }


    private void SetNextSectionSeq()
    {
        if (soundCues.GetMaxSections() != currentSection - 1)
        {
            playerStats.BonusO2();

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





