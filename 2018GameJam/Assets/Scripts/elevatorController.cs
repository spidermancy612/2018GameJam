using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class elevatorController : MonoBehaviour
{

    public GameObject elevator;
    public GameObject message;

    private bool runOnce;
    private universalReciever reciever;
    private bool isInteracting;

    private bool isInTrigger;

    /////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
        reciever = GetComponent<universalReciever>();
        message.SetActive(false);
        runOnce = true;
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    private void Update()
    {
       
        if (reciever.getLight() && Input.GetKeyDown(KeyCode.F) && isInTrigger)
        {
            elevator.GetComponent<moveElevator>().setIsMoving();
        }

        if(runOnce && reciever.getSound())
        {
            runOnce = false;
            elevator.GetComponent<moveElevator>().setIsMoving();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerEnter(Collider other)
    {
        if (reciever.getLight())
        {
            message.SetActive(true);
        }

        if (other.tag == "Player")
        {
            isInTrigger = true;
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerExit(Collider other)
    {
        message.SetActive(false);

        if (other.tag == "Player")
        {
            isInTrigger = false;
        }
    }
}
