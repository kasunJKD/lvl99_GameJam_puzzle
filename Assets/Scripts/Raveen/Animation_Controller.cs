using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controller : MonoBehaviour
{

    private Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = (Input.GetKey("w") || Input.GetKey("s") | Input.GetKey("a") | Input.GetKey("d"));
        bool runPressed = Input.GetKey("left shift");
        
        
        if (Input.GetKey("space"))
        {
            animator.SetBool("isGrab", true);
        }

        if (!Input.GetKey("space"))
        {
            animator.SetBool("isGrab", false);
        }

        // if w pressed
        if (!isWalking && forwardPressed)
        {
            // bool true
            animator.SetBool(isWalkingHash, true);
        }

        // relese w
        if (isWalking && !forwardPressed)
        {
            // bool false
            animator.SetBool(isWalkingHash, false);
        }

        //
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && (!forwardPressed && !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }


    }
}
