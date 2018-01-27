using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAnim : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.Play("Door Open");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
