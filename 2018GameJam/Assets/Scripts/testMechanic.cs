using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make sure there is a universalReciever component on the object
[RequireComponent(typeof(universalReciever))]

public class testMechanic : MonoBehaviour {

    private universalReciever reciever;         // Reference for universalReciever component on this object

    public GameObject testObject;               // Object we're effecting 

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    void Start () {
        //Set the component reference for the reciever so we can access it
        reciever = GetComponent<universalReciever>();
	}

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    void Update () {
        //GetLight() returns the boolean of the light state
        //If true that means the light is on
		if (reciever.getLight())
        {
            testObject.SetActive(true);
        }
        //Otherwise it means the light is off
        else
        {
            testObject.SetActive(false);
        }
	}
}
