using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

    PlayerLocomotion movement;
    InputHandler inputHandler;
    private Animator animator;

    private float horizontal;
    private float vertical;

    void Start()
    {
        movement = GetComponent<PlayerLocomotion>();
        inputHandler = GetComponent<InputHandler>();
        animator = GetComponent<Animator>();
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
    }

}
