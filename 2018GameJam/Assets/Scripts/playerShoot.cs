using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour {

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    void Start () {
		
	}
	
	/////////////////////////////////////////////////////////////////////////////////////////////////////
	void Update () {
        checkPlayerInput();
	}

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    private void checkPlayerInput ()
    {
        //left click - for lights
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider.tag == "light")
                {
                    Debug.Log("Hit Light");
                }
            }
        }

        //right click - for sounds
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider.tag == "sound")
                {
                    Debug.Log("Hit sound");
                }
            }
        }
    }
}
