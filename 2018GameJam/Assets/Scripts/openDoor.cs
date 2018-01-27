using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class openDoor : MonoBehaviour {

    public GameObject door;
    public GameObject message;
    public float doorDelay;

    private universalReciever reciever;
    private bool isInteracting;

    private Animator anim;

    private float timer;

    //true = closed door, false = opened door
    private bool doorState;

	/////////////////////////////////////////////////////////////////////////////////////////
	void Start ()
    {
        doorState = true;
        reciever = GetComponent<universalReciever>();
        message.SetActive(false);

        anim = door.GetComponent<Animator>();
	}

    /////////////////////////////////////////////////////////////////////////////////////////
    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F))
        {
            isInteracting = true;
        }
        else
        {
            isInteracting = false;
        }
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
       if(isInteracting && reciever.getLight())
        {
            
            doorState = !doorState;

            if (timer <= 0)
            {
                if (doorState)
                {
                    anim.Play("Opening");
                }
                else
                {
                    anim.Play("Closing");
                }

                timer = doorDelay;
            }
            
            
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerExit(Collider other)
    {
        message.SetActive(false);
    }
}
