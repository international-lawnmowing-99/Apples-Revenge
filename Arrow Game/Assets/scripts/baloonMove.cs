using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloonMove : MonoBehaviour {

    public float leftBoundary, rightBoundary, speed, oscillation;
    bool movingForwards = true;
    public bool vacillating;

    baloonMove(float left, float right, float newSpeed, bool wafting)
    {
        leftBoundary = left;
        rightBoundary = right;
        newSpeed = speed;
        vacillating = wafting;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (movingForwards)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (transform.position.x <= leftBoundary)
        {
            movingForwards = true;
        }
        if (transform.position.x >= rightBoundary)
        {
            movingForwards = false;
        }

        if (vacillating)
        {
            transform.position += new Vector3(0, oscillation * Mathf.Sin(Time.time) * Time.deltaTime, 0);
        }
	}
}
