using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private DoorAnimator _doorAnimator;
    public InputHandler _inputHandler;
    
    private bool inTrigger;
    // Start is called before the first frame update
    void Start()
    {
        _doorAnimator = GetComponent<DoorAnimator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputHandler.isInteracting && inTrigger)
        {
            _doorAnimator.OpenDoor();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }
}
