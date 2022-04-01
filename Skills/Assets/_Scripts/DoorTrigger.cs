using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Inventory;
using _Scripts.Items;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private DoorAnimator _doorAnimator;
    public Inventory _inventory;
    public InputHandler _inputHandler;
    public InventoryItem key;

    private bool inTrigger;

    private bool hasKey;
    // Start is called before the first frame update
    void Start()
    {
        _doorAnimator = GetComponent<DoorAnimator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckKey(key);
        if (_inputHandler.isInteracting && inTrigger && hasKey)
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

    private void CheckKey(InventoryItem key)
    {
        for (int i = 0; i < _inventory.inventory.Count; i++)
        {
            if (key.itemData.name.Contains(key.itemData.name))
            {
                hasKey = true;
            }
            else
            {
                hasKey = false;
            }
        }
    }
}
