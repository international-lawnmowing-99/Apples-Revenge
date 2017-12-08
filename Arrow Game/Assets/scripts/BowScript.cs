using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowScript : MonoBehaviour {

    public GameObject drawStrengthText;
    public GameObject arrow;

    bool determiningVerticalAngle = false;
    bool determiningDrawStrength = false;

    bool movingOnUp = true;
    bool drawPullIncreasing = true;

    public float rotationSpeed = 10;
    public float MAXANGLE = 25;

    [HideInInspector]
    public float verticalAngle = 0;
    [HideInInspector]
    public float drawStrength = 0;
    public float playerStrength = 1;


    // Use this for initialization
    void Start () {
        determiningVerticalAngle = true;
    }

    // Update is called once per frame
    void Update () {
        //Loop for vertical angle
        if (determiningVerticalAngle)
        {
            if (movingOnUp)
            {
                verticalAngle += rotationSpeed * Time.deltaTime;
                if (verticalAngle >= MAXANGLE)
                {
                    movingOnUp = false;
                }
            }
            else
            {
                verticalAngle -= rotationSpeed * Time.deltaTime;
                if (verticalAngle <= -MAXANGLE)
                {
                    movingOnUp = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                determiningVerticalAngle = false;
                determiningDrawStrength = true;
            }
        }

        if (determiningDrawStrength)
        {
            if (drawPullIncreasing)
            {
                drawStrength += playerStrength * Time.deltaTime;

                if (drawStrength >= 100)
                {
                    drawPullIncreasing = false;
                }
            }
            else if (!drawPullIncreasing)
            {
                drawStrength -= playerStrength * Time.deltaTime;
            }


            if (Input.GetKeyUp(KeyCode.Space) || drawStrength <= 0)
            {
                drawPullIncreasing = true;
                determiningDrawStrength = false;
                Shoot();
                determiningVerticalAngle = true;
            }
        }


        Quaternion rotation = transform.localRotation;
        rotation.eulerAngles = new Vector3(0, verticalAngle, 0);
        transform.localRotation = rotation;

//        drawStrengthText.GetComponent<Text>().text = "Draw stength = " + drawStrength.ToString();
        
    }
    void Shoot()
    {
        Instantiate(arrow, transform.position, Quaternion.Euler(0, 0, 90), null);
        Data.numberOfArrowsUsed++;
    }
}
