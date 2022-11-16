using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSwitch : MonoBehaviour
{
    public GameObject Dialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeDialogue()
    {
        Dialog.SetActive(false);
    }
}
