using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D _rb;
    [SerializeField] private PlayerData data;
    private PlayerInput _input;

    void Awake()
    {
        _input = new PlayerInput();
    }

    void OnEnable()
    {
        _input.Enable();
    }

    void OnDisable()
    {
        _input.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(-7.5f, -2.0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        data.moveDir = _input.Move.Horizontal.ReadValue<Vector2>();

    }

    void FixedUpdate()
    {

        float targetSpeed = data.moveDir.x * data.playerSpeed;
        float speedDif = targetSpeed - _rb.velocity.x;
        float accelRate = (Mathf.Abs(targetSpeed) < 0.01f) ? data.acceleration : data.decceleration;
        float movement = Mathf.Pow(Mathf.Abs(speedDif) * accelRate, data.velPower) * Mathf.Sign(speedDif);

        _rb.AddForce(movement * Vector2.right * Time.deltaTime);

        if (Mathf.Abs(data.moveDir.x) < 0.01f)
        {
            float amount = Mathf.Min(Mathf.Abs(_rb.velocity.x), Mathf.Abs(data.frictionAmount));
            amount *= Mathf.Sign(_rb.velocity.x);
            _rb.AddForce(Vector2.right * -amount, ForceMode2D.Impulse);
        }

    }
}
