using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class lightParticleController : MonoBehaviour {

    public bool startActive;
    public GameObject activeParticles;
    public GameObject inactiveParticles;
    universalReciever reciever;

    /////////////////////////////////////////////////////////////////////////////////////////
    private void Start()
    {
        reciever = GetComponent<universalReciever>();
        
        //is a source at start
        if(startActive)
        {
            reciever.updateLight();
            activeParticles.SetActive(true);
            inactiveParticles.SetActive(false);
        }
        else
        {
            activeParticles.SetActive(false);
            inactiveParticles.SetActive(true);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    void Update () {

        //check set the right particle effects on
        if(reciever.getLight())
        {
            activeParticles.SetActive(true);
            inactiveParticles.SetActive(false);
        }
        else
        {
            activeParticles.SetActive(false);
            inactiveParticles.SetActive(true);
        }
		
	}
}
