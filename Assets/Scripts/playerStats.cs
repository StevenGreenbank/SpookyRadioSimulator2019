using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public const int MAX_HEALTH = 100;
    public const int MIN_HEALTH = 1;
    public const int PUNISHMENT = 33;
    public const int SLOW_LEAK = 1;
    public const int RATINGS_GAIN = 1;

    public PlayerStats playerStats;

    int oxygen;
    int ratings;

	// Use this for initialization
	void Start () {
        oxygen = 100;
        ratings = 20;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetO2Max()
    {
        oxygen = MAX_HEALTH;
    }

    public void PunishO2()
    {
        oxygen -= PUNISHMENT;
    }

    public void LoseRatings(int lost)
    {
        ratings -= lost;
        if (ratings < 0)
        {
            ratings = 0;
        }
    }

    public void LeakO2()
    {
        oxygen -= SLOW_LEAK;
    }

    public void BonusO2()
    {
        oxygen += ratings;

        if (oxygen > MAX_HEALTH)
        {
            oxygen = MAX_HEALTH;
        } 
    }

    public bool IsDead()
    {
        return oxygen < MIN_HEALTH;
    }

    public void GainRatings()
    {
        ratings += RATINGS_GAIN;
    }

    



}
