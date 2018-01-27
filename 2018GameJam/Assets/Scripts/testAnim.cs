using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAnim : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.Play("Opening");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.Play("Closing");
        }
	}
}
