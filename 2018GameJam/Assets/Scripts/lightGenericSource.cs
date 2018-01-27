using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class lightGenericSource : MonoBehaviour {

    /*
     * Place script on objects in scene that you want the player to be able to turn the light on for.
     * Make sure first child is the light source.
     * When the player left clicks the light will switch between on and off.
     */

    private universalReciever reciever;
    private GameObject lightSource;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Method called once at start of scene. Handles settings variables
    private void Start()
    {
        reciever = GetComponent<universalReciever>();
        lightSource = transform.GetChild(0).gameObject;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Method called every frame. Checks if light is enabled.
    private void Update()
    {
        if (reciever.getLight())
        {
            lightSource.SetActive(true);
        }
        else
        {
            lightSource.SetActive(false);
        }
    }
}
