using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class CameraMove : MonoBehaviour {

    public GameObject arrow;
    Vector3 position;
    float currentZ;
    public float cameraDistance = 41.5f;
    public float offsetX = 0, offsetY = 0;
	void Awake () {
	}
	
	void Update () {

        arrow = GameObject.FindGameObjectWithTag("arrow");

        if (arrow != null)
        {
            position = arrow.transform.position + new Vector3(offsetX, offsetY, 0);
            currentZ = arrow.transform.position.z;
            position.z = transform.position.z;

        }

        else
        {

            position = transform.position;
            position.z = -cameraDistance;
        }
        

        //position.z = currentZ -10 /(1 + 1 * Mathf.Pow(2.18f, - counter/60));
        transform.position = position;

        }

    }