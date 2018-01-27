using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMechanic : MonoBehaviour {

    private universalReciever reciever;

    public GameObject testObject;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    void Start () {
        reciever = GetComponent<universalReciever>();
	}

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    void Update () {
		if (reciever.getLight())
        {
            testObject.SetActive(true);
        }
        else
        {
            testObject.SetActive(false);
        }
	}
}
