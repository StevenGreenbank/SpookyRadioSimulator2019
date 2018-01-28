using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCues : MonoBehaviour {

    public const int MAX_SECTIONS = 3;
    public const int MAX_CLIPS = 3;

    int[] sectionLength = new int[MAX_SECTIONS];
    TimelineCue[,] cueList = new TimelineCue[MAX_SECTIONS, MAX_CLIPS];
    string[] soundClipName = new string[MAX_SECTIONS];

    public int SectionLength(int currentSection)
    {
        return sectionLength[currentSection];
    }
    
        
   public TimelineCue GetCue(int currentSection, int cueIndex)
   {
        return cueList[currentSection, cueIndex];
   }

    public string GetClipName(int currentSection)
    {
        return soundClipName[currentSection];
    }


}
