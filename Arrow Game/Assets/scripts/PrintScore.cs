using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("num arrows = " + Data.numberOfArrowsUsed);
        Debug.Log("best = " + Data.bestArrowsUsed);
        if (Data.numberOfArrowsUsed <= Data.bestArrowsUsed)
        {
            Data.bestArrowsUsed = Data.numberOfArrowsUsed;
        }

        gameObject.GetComponentInChildren<Text>().text = "You used " + Data.numberOfArrowsUsed + " Arrows.\nYour best result is " + Data.bestArrowsUsed + ". ";
        Data.numberOfArrowsUsed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
