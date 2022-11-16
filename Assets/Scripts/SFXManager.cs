using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    IDictionary<string, AudioClip> soundEffect = new Dictionary<string, AudioClip>();

    static SFXManager sfx;

    /*[SerializeField] AudioSource crowdSource;
    [SerializeField] AudioSource carSource;
    [SerializeField] AudioSource winSource;
    [SerializeField] AudioSource failSource;*/
    [SerializeField] AudioSource sourceAudio;
    [SerializeField] List<AudioClip> sounds = new List<AudioClip>();

    void Awake()
    {
        sfx = this;

        soundEffect.Add("Cheering", sounds[0]);
        soundEffect.Add("Engine", sounds[1]);
        soundEffect.Add("Fail", sounds[2]);
        soundEffect.Add("Win", sounds[3]);
    }

    public void PlaySound(string soundName)
    {
        //soundEffect[soundName].Play();
        sourceAudio.PlayOneShot(soundEffect[soundName]); // sound effects cut off because thats how playOneShot works, let me use the actual methods that were designed to loop audio and then ill give you a working program
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
