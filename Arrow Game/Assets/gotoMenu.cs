using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(displayScore());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator displayScore()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
