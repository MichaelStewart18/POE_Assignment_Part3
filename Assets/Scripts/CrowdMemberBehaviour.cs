using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdMemberBehaviour : MonoBehaviour
{
    //the crowd manager
    CrowdManager Manager;

    //the timer which actually counts down
    public float TimerToAnimation;

    //reference to this animator component
    private Animator AnimationComponent;

    //mirror of the crowd manager value
    public int NumberOfAnimations;

    // Start is called before the first frame update
    void Start()
    {

        //components found here for easy reference
        Manager = GameObject.FindObjectOfType<CrowdManager>();
        AnimationComponent = GetComponent<Animator>();

        //sets the timer in start so each animation gets a random starting offset when hitting play
        TimerToAnimation = Random.Range(Manager.TimerMinLimit, Manager.TimerMaxLimit);
    }

    // Update is called once per frame
    void Update()
    {
        //randomly picks an animation state
        RandomStateTransition();
    }


    public void RandomStateTransition()
    {
        //checks if the timer until the next animation is 0
        if (TimerToAnimation <= 0 )
        {
            //sets the timer back to a random value between the high and low set on the crowd manager
            TimerToAnimation = Random.Range(Manager.TimerMinLimit, Manager.TimerMaxLimit);

            //picks an animation from 0 to the total number of animations
            AnimationComponent.SetInteger("StateNumber", Random.Range(0, NumberOfAnimations));
            
        }
    }


}
