using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed=5f;
    private Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        playerAnimator.SetBool("North", false);
        playerAnimator.SetBool("south", false);
        playerAnimator.SetBool("Right", false);
        playerAnimator.SetBool("Left", false);

        if (Input.GetKey(KeyCode.W))//moves it north
        {
            transform.Translate(Vector3.up * Time.deltaTime * playerSpeed);
            
            playerAnimator.SetBool("south", true);//this is right,i messed up the naming;(
        }
        else if (Input.GetKey(KeyCode.S))// moves it south
        {
            transform.Translate(Vector3.down * Time.deltaTime * playerSpeed);
           
            playerAnimator.SetBool("North", true);
        }
        else if(Input.GetKey(KeyCode.D))//moves the player right
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
            playerAnimator.SetBool("Right", true);
        }
        else if( Input.GetKey(KeyCode.A))//
        {
            transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);
            playerAnimator.SetBool("Left", true);
        }
            
    }
}
