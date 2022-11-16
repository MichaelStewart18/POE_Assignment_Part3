using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerRaceCar")
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
