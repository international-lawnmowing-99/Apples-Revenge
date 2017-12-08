using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnColliderEnter(Collider other)
    {
        if (other.tag == "arrow")
        {
            Debug.Log("hit target!");
            gameObject.transform.parent = null;
        }
    }
}
