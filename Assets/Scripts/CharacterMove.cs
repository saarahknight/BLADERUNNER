using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;
    public bool isRunning;
    public bool backwardsCheck = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            print("Hello World");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
			
        }
        else
        {
            isRunning = false;
        }
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            if (Input.GetButton("SKey"))
            {
                backwardsCheck = true;
                thePlayer.GetComponent<Animator>().Play("");
            }
            else
            {
                backwardsCheck = false;
                if (isRunning == false)
                {
                    thePlayer.GetComponent<Animator>().Play("");
                }
                else
                {
                    thePlayer.GetComponent<Animator>().Play("");
                }

            }
            if (isRunning == false)
            {
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 1.5f;
            }
            if (isRunning == true && backwardsCheck == false)
            {
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 10.1f;
            }
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;

            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);
        }
        else
        {
            isMoving = false;
            thePlayer.GetComponent<Animator>().Play("");
        }
    }

}
