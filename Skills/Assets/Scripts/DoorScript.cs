using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public PlayerData data;
    public ItemObject key;

    private bool hasKey;
    private bool onDoor = false;

    // Update is called once per frame
    void Update()
    {

        CheckKey(key);
        if (onDoor == true && data.input.Move.Interact.IsPressed())
        {
            gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Player");
            if (col.CompareTag("Player"))
            {
                onDoor = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Player");
            if (col.CompareTag("Player"))
            {
                onDoor = false;
            }
        }
    }

    private void CheckKey(ItemObject _item)
    {
        for (int i = 0; i < data.inventory.container.Count; i++)
        {
            if (data.inventory.container[i].item == _item)
            {
                hasKey = true;
            }
        }
    }
}
