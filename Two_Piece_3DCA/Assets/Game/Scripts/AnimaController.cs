using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaController : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    int isWalkingFHash;
    int isWalkingBHash;
    int isWalkingLHash;
    int isWalkingRHash;
    int isJumpingHash;
    private void Start()
    {
        animator = player.GetComponent<Animator>();
        isWalkingFHash = Animator.StringToHash("isWalkingFront");
        isWalkingBHash = Animator.StringToHash("isWalkingBack");
        isWalkingLHash = Animator.StringToHash("isStrafingLeft");
        isWalkingRHash = Animator.StringToHash("isStrafingRight");
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingFHash);
        bool isWalkingB = animator.GetBool(isWalkingBHash);
        bool isWalkingL = animator.GetBool(isWalkingLHash); 
        bool isWalkingR = animator.GetBool(isWalkingRHash);
        bool isJumping = animator.GetBool(isJumpingHash);

        bool isWpressed = Input.GetButton("Front");

        if(!isWalking && isWpressed)
        {
            animator.SetBool(isWalkingFHash, true);
        }
        if(isWalking && !isWpressed)
        {
            animator.SetBool(isWalkingFHash, false);
        }
       
        bool isSpressed = Input.GetButton("Backward");
        if (!isWalkingB && isSpressed)
        {
            animator.SetBool(isWalkingBHash, true);
        }
        if (isWalkingB && !isSpressed)
        {
            animator.SetBool(isWalkingBHash, false);
        }

        
        bool isApressed = Input.GetButton("Left");
        if (!isWalkingL && isApressed)
        {
            animator.SetBool(isWalkingLHash, true);
        }
        if (isWalkingL && !isApressed)
        {
            animator.SetBool(isWalkingLHash, false);
        }

       
        bool isDpressed = Input.GetButton("Right");
        if (!isWalkingR && isDpressed)
        {
            animator.SetBool(isWalkingRHash, true);
        }
        if (isWalkingR && !isDpressed)
        {
            animator.SetBool(isWalkingRHash, false);
        }
        bool isSpace = Input.GetButton("Jump");
        if (!isJumping && isSpace)
        {
            animator.SetBool(isJumpingHash, true);
        }
        if (isWalkingR && !isDpressed)
        {
            animator.SetBool(isJumpingHash, false);
        }



    }
}
