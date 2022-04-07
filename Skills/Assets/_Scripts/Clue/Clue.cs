using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    private InputHandler _inputHandler;
    public ClueObject canvas;

    private bool isTrigger;

    void Start()
    {
        _inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrigger && _inputHandler.isInteracting)
        {
            canvas.OpenCanvas();
        }

        if (!isTrigger)
        {
            canvas.CloseCanvas();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isTrigger = false;
        }
    }
}
