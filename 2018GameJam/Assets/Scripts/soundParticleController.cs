using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]
[RequireComponent(typeof(AudioSource))]

public class soundParticleController : MonoBehaviour {

    public bool startActive;
    public GameObject activeParticles;
    public GameObject inactiveParticles;

    public AudioClip activeSound;
    public AudioClip inactiveSound;

    public float activeVolume;
    public float inactiveVolume;

    universalReciever reciever;
    AudioSource audioSource;

    /////////////////////////////////////////////////////////////////////////////////////////
    private void Start()
    {
        reciever = GetComponent<universalReciever>();
        audioSource = GetComponent<AudioSource>();
        
        //is a source at start
        if(startActive)
        {
            reciever.updateSound();
            activeParticles.SetActive(true);
            inactiveParticles.SetActive(false);

            audioSource.clip = activeSound;
            audioSource.Play();

        }
        else
        {
            activeParticles.SetActive(false);
            inactiveParticles.SetActive(true);

            audioSource.clip = inactiveSound;
            audioSource.Play();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    void Update () {

        //check set the right particle effects on
        if(reciever.getSound())
        {
            activeParticles.SetActive(true);
            inactiveParticles.SetActive(false);

            audioSource.clip = activeSound;
            audioSource.volume = activeVolume;
        }
        else
        {
            activeParticles.SetActive(false);
            inactiveParticles.SetActive(true);

            audioSource.clip = inactiveSound;
            audioSource.volume = inactiveVolume;
        }
        //plays sound
        if (reciever.recentSoundChange())
        {
            audioSource.Play();
        }

    }
}
