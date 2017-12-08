using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowScript : MonoBehaviour {
    float horizontalVelocity,verticalVelocity;
    public GameObject bow;
    public BowScript bowscript;
    public float gravity = 4.0f;


    public GameObject bullseyeText;
    GameObject theCamera;
	// Use this for initialization
	void Start () {
        bow = GameObject.FindGameObjectWithTag("bow");
        bowscript = bow.GetComponent<BowScript>();
        float angle = bowscript.verticalAngle;
        float velocity = bowscript.drawStrength;
        bowscript.drawStrength = 0;

        verticalVelocity = velocity * Mathf.Sin(Mathf.Deg2Rad*angle);
        horizontalVelocity = velocity * Mathf.Cos(Mathf.Deg2Rad*angle);

        theCamera = GameObject.FindGameObjectWithTag("MainCamera");

        //theCamera.GetComponent<CameraMove>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {

        float angle = Mathf.Atan(verticalVelocity / horizontalVelocity);
        angle *= Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, + angle);
        verticalVelocity -= gravity * Time.deltaTime;
        transform.localPosition += new Vector3(horizontalVelocity, verticalVelocity ,0) * Time.deltaTime;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            bullseyeText = GameObject.FindGameObjectWithTag("bullseye");
            bullseyeText.GetComponent<Text>().text = "";
            //theCamera.GetComponent<CameraMove>().enabled = true;

            Destroy(gameObject);
        Debug.Log("hit ground");


        }
        else if (other.gameObject.tag == "baloon")
        {
            Destroy(other.gameObject);
            
            Debug.Log("Hit baloon! Well done!");
        }
        else if (other.gameObject.tag == "target")
        {
            other.gameObject.transform.parent.parent = null;
            StartCoroutine(showBullseyeText());
            Debug.Log("Hit target! Bulls eye!");
        }
    }

    IEnumerator showBullseyeText()
    {
        bullseyeText = GameObject.FindGameObjectWithTag("bullseye");
        bullseyeText.GetComponent<Text>().text = "Bullseye!";
        yield return new WaitForSeconds(.3f);
        bullseyeText.GetComponent<Text>().text = "";
        Debug.Log("yolo");
    }
}

