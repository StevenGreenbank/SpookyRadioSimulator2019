using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineQueue : MonoBehaviour {

    Queue<TimelineCue> timelineQueue;
    int section;

    public void Start()
    {
        Init();
    }


    public void Init()
    {
        timelineQueue = new TimelineQueue;
        section = 0;
    }


    public void SetSection(int section_in)
    {
        section = section_in;
    }

    public int GetSection()
    {
        return section;
    }


    public void NextSection()
    {
        section++;
    }


    public void Clear()
    {
        timelineQueue.Clear();
    }

    public TimelineCue Peek()
    {
        return timelineQueue.Peek();
    }

    public void Next()
    {
        timelineQueue.Dequeue();
    }


    public void Enqueue(TimelineCue inCue)
    {
        timelineQueue.Enqueue(inCue);
    }

    public void Enqueue(Time inStart, Time inEnd, float inVolume)
    {
        TimelineCue inCue = new TimelineCue();
        inCue.timeStart = inStart;
        inCue.timeEnd = inEnd;
        inCue.volume = inVolume;

        timelineQueue.Enqueue(inCue);
    }


}
