using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

    PlayerLocomotion movement;
    InputHandler inputHandler;
    public Animator animator;

    private float horizontal;
    private float vertical;

    void Start()
    {
        movement = GetComponent<PlayerLocomotion>();
        inputHandler = GetComponent<InputHandler>();
    }

    void Update()
    {

        WalkingAnim();

    }

    private void WalkingAnim()
    {
        horizontal = inputHandler.movementInput.x;
        vertical = inputHandler.movementInput.y;
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Speed", inputHandler.movementInput.SqrMagnitude());

        if (horizontal == 1 || horizontal == -1 || vertical == 1 || vertical == -1)
        {
            animator.SetFloat("LastHorizontal", horizontal);
            animator.SetFloat("LastVertical", vertical);
        }
    }

}
