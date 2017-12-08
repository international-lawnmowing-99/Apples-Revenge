using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene1 : MonoBehaviour {

    Scene menu;
    public Scene scene1;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


	}
    void OnMouseDown()

    {
        SceneManager.LoadScene(1);

        Debug.Log("Attempting to change scene");
    }
}
