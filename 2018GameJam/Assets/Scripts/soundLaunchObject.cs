using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(universalReciever))]

public class soundLaunchObject : MonoBehaviour {

    universalReciever reciever;
    bool runOnce;
    public Vector3 launchAngle;
    public float launchSpeed;
    public float objectMass;
    private Rigidbody rb;
	
    
    ////////////////////////////////////////////////////////////////////////////////////////////

	void Start ()
    {
        runOnce = true;
        reciever = GetComponent<universalReciever>();
	}

    ////////////////////////////////////////////////////////////////////////////////////////////

    private void Update()
    {
        //launches the object in the air if it recieves sound and hasn't been launched before.
        if (runOnce && reciever.getSound())
        {
            runOnce = false;
            gameObject.AddComponent(typeof(Rigidbody));
            rb = GetComponent<Rigidbody>();
            rb.mass = objectMass;
            rb.AddForce(launchAngle*launchSpeed);
            rb.AddTorque(launchAngle*launchSpeed);
        }
    }
}
