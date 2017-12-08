using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour {
    public GameObject winText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.childCount == 0)
        {
            winText.GetComponent<Text>().text = "You win!";
            winText.SetActive(true);
            StartCoroutine(GoToResults());

        }
	}
    IEnumerator GoToResults()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
        Debug.Log("moving to results");

    }
}
