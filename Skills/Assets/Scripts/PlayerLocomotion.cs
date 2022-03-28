using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerLocomotion : MonoBehaviour
{

    InputHandler inputHandler;
    Vector3 moveDir;
    public PlayerStats playerStats;

    private Rigidbody2D _rb;



    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        inputHandler = GetComponent<InputHandler>();
    }

    public void Update()
    {
        float delta = Time.deltaTime;

        inputHandler.TickInput(delta);
    }

    public void FixedUpdate()
    {

        float fixedDelta = Time.fixedDeltaTime;

        HandleMovement(fixedDelta);

    }

    private void HandleMovement(float fixedDelta)
    {
        moveDir = new Vector2(inputHandler.horizontal, inputHandler.vertical) * Time.deltaTime;

        moveDir.Normalize();

        float speed = playerStats.playerSpeed;
        moveDir *= speed;

        _rb.velocity = moveDir * Time.deltaTime;
    }

}
