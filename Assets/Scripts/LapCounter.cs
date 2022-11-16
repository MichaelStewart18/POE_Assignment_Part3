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

    private void OnTriggerEnter(Collider other)
    {
        
        lapCount++;
        if(other.gameObject.CompareTag("StartLine"))
        {
            if (lapCount < 3)
            {
                lapCounter.text = "Lap: " + lapCount;
                

                Debug.Log("passed the checkpoint");
                Debug.Log(lapCount);

                //sfxManager.PlaySound("Win");
            } 
            else if(lapCount >= 3)
            {
                lapCounter.text = "FINSIH!";
                sfxManager.PlaySound("Win");
            }
        }
    }
}
