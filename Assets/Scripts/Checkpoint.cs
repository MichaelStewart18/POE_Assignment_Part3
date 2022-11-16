using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //Destroys the checkpoint
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerRacecar Variant")
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
