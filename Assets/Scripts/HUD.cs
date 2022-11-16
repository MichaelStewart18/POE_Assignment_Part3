using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public int timeLeft;
    public Text timeDisplay;
    public Text winLoss;

    IEnumerator TimeRemaining()
    {
        while(timeLeft > 0)
        {
            timeDisplay.text = timeLeft.ToString();

            yield return new WaitForSeconds(1f);

            timeLeft--;

            timeDisplay.text = "Time Left: " + timeLeft;
        }

        winLoss.text = "You Lose";

        yield return new WaitForSeconds(1f);

        //timeDisplay.gameObject.setActive(false);

    }

    public static int seconds;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
