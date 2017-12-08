using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonListener : MonoBehaviour {

    public Button button1;
    // Use this for initialization
    void Start()
    {
        button1.onClick.AddListener(() => SceneManager.LoadScene(1));
        if (Data.bestArrowsUsed == 0)
        {
            Data.bestArrowsUsed = int.MaxValue;
        }
    }
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
