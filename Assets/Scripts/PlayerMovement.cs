using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D myController;

    public Animator animator;

    public float movementSpeed = 40f;

    float horizontalAxis = 0f;

    bool jump = false;


    // Update is called once per frame
    void Update()
    {
       horizontalAxis = Input.GetAxisRaw("Horizontal") * movementSpeed;

       animator.SetFloat("speed", Mathf.Abs(horizontalAxis));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping",true);
        }
    }

    public void Landing()
    {
        animator.SetBool("isJumping", false);

    }
    
    void FixedUpdate ()
    {
        //Move our character
        //Time.fixedDeltaTime ensures we move the same amount no matter
        //how many times my function is called

        myController.Move(horizontalAxis * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
