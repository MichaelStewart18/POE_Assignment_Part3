using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapCounter : MonoBehaviour
{
    public GameObject finishLap;
    public Text lapCounter;
    public SFXManager sfxManager;
    public int lapCount = 0;
    public GameObject End;

    private void OnTriggerEnter(Collider other)
    {        
        lapCount++;

        if(other.gameObject.CompareTag("StartLine"))
        {
            //Check to see whether you have completed 3 laps or not if not it keeps counting.
            if (lapCount < 3)
            {
                lapCounter.text = "Lap: " + lapCount;
                
            } 
            //If you have completed 3 laps it will trigger the finished text and allows you to end the race.
            else if(lapCount >= 3)
            {
                lapCounter.text = "FINSIH!";
                sfxManager.PlaySound("Win");
                End.SetActive(true);
                
            }
        }
    }
}
