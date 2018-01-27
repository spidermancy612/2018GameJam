using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class lightParticleController : MonoBehaviour {

    public bool startActive;
    public GameObject activeParticles;
    public GameObject inActiveParticles;
    universalReciever reciever;

    /////////////////////////////////////////////////////////////////////////////////////////
    private void Start()
    {
        reciever = GetComponent<universalReciever>();
        
        //is a source at start
        if(startActive)
        {
            activeParticles.SetActive(true);
            inActiveParticles.SetActive(false);
        }
        else
        {
            activeParticles.SetActive(false);
            inActiveParticles.SetActive(true);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    void Update () {

        //check set the right particle effects on
        if(reciever.getLight())
        {
            activeParticles.SetActive(true);
            inActiveParticles.SetActive(false);
        }
        else
        {
            activeParticles.SetActive(false);
            inActiveParticles.SetActive(true);
        }
		
	}
}
