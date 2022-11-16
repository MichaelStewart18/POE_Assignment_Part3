using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdManager : MonoBehaviour
{
    public SFXManager SoundManager;

    //the animator components of the crowd members
    [SerializeField] Animator[] CrowdMemberAnimations;

    //the nummber of total animations
    [SerializeField] int NumberOfAnimations;

    //the low and high limits for the random timer
    public float TimerMinLimit, TimerMaxLimit;

    //used to start all the timers
    public bool StartTimers;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //sets all of the crowd members animation count to the total number of animations
        for (int i = 0; i < CrowdMemberAnimations.Length; i++)
        {
            CrowdMemberAnimations[i].GetComponent<CrowdMemberBehaviour>().NumberOfAnimations = NumberOfAnimations;            
        }

        SoundManager.PlaySound("Cheering");
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the timers can be started
        if (StartTimers)
        {
            for (int i = 0; i < CrowdMemberAnimations.Length; i++)
            {
                //makes the individual timers count down
                CrowdMemberAnimations[i].GetComponent<CrowdMemberBehaviour>().TimerToAnimation -= Time.deltaTime;
            }

        }
    }

    

}
