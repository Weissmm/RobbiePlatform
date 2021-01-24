using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    PlayerMovement movement;
    Rigidbody2D rb;

    int groundID;
    int hangingID;
    int crouchID;
    int speedID;
    int fallID;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rb=GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        movement=GetComponentInParent<PlayerMovement>();
    
        groundID=Animator.StringToHash("isOnGround");
        hangingID=Animator.StringToHash("isHanging");
        crouchID=Animator.StringToHash("isCrouching");
        speedID=Animator.StringToHash("speed");
        fallID=Animator.StringToHash("verticalVelocity");
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(speedID,Mathf.Abs(movement.xVelocity));
        //anim.SetBool("isOnGround",movement.isOnGround);
        anim.SetBool(groundID,movement.isOnGround);
        anim.SetBool(hangingID,movement.isHanging);
        anim.SetBool(crouchID,movement.isCrouch);
        anim.SetFloat(fallID,rb.velocity.y);
    }

    public void StepAudio(){
        AudioManager.PlayFootStepAudio();
    }

    public void CrouchStepAudio(){
        AudioManager.PlayCrouchFootStepAudio();
    }

}
