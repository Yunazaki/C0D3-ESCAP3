using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    public float horizontal;
    public float vertical;
    public float moveAmount;
    public bool isSprinting;

    public PlayerControls inputActions;

    public Vector2 movementInput;
    public bool isInteracting;

    public void OnEnable()
    {

        if (inputActions == null)
        {
            inputActions = new PlayerControls();
            inputActions.PlayerMovement.Movement.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
            inputActions.PlayerMovement.SprintStart.performed += x => SprintPressed();
            inputActions.PlayerMovement.SprintEnd.performed += x => SprintReleased();
            inputActions.PlayerMovement.InteractStart.performed += x => InteractPressed();
            inputActions.PlayerMovement.InteractEnd.performed += x => InteractReleased();
        }

        inputActions.Enable();

    }

    public void OnDisable()
    {
        inputActions.Disable();
    }

    public void TickInput(float delta)
    {
        MoveInput(delta);
    }

    private void MoveInput(float delta)
    {
        horizontal = movementInput.x;
        vertical = movementInput.y;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
    }

    private void SprintPressed()
    {
        isSprinting = true;
    }

    private void SprintReleased()
    {
        isSprinting = false;
    }

    private void InteractPressed()
    {
        isInteracting = true;
    }

    private void InteractReleased()
    {
        isInteracting = false;
    }

}
