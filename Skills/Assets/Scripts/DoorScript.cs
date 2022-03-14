using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public PlayerData data;
    public ItemObject key;

    private bool hasKey;

    // Update is called once per frame
    void Update()
    {

        CheckKey(key);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            Debug.Log("Player");
            if (hasKey && data.isInteracting)
            {
                Debug.Log("Key");
                gameObject.SetActive(false);
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
