using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveElevator : MonoBehaviour {

    public float height;
    public float speed;

    float startPosition;
    float currentPosition;
    bool isUp;
    bool isMoving;
	// Use this for initialization
	void Start ()
    {
        startPosition = transform.position.y;
        currentPosition = transform.position.y;
        isUp = false;
    }
	
	// Update is called once per frame
	void Update ()
    {

        //move up
        if (!isUp && isMoving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            currentPosition = transform.position.y;
            if (currentPosition >= height + startPosition)
            {
                isMoving = false;
                isUp = true;
            }
        }
        //move down 
        else if (isUp && isMoving)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            currentPosition = transform.position.y;
            if (currentPosition <= startPosition)
            {
                isMoving = false;
                isUp = false;
            }
        }

	}

    public void setIsMoving()
    {
        isMoving = !isMoving;
    }

}
