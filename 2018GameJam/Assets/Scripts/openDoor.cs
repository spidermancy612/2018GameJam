using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class openDoor : MonoBehaviour {

    public GameObject door;
    public GameObject message;
    universalReciever reciever;


    //true = closed door, false = opened door
    bool doorState;


	/////////////////////////////////////////////////////////////////////////////////////////
	void Start ()
    {
        doorState = true;
        reciever = GetComponent<universalReciever>();
        message.SetActive(false);
	}

    /////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerEnter(Collider other)
    {
        if(reciever.getLight())
        {

            message.SetActive(true);
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerStay(Collider other)
    {
       //check for button press
       if(Input.GetKeyDown(KeyCode.F) && reciever.getLight())
        {
            
            doorState = !doorState;
            //play animation
            door.SetActive(doorState);
            
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerExit(Collider other)
    {
        message.SetActive(false);
    }
}
