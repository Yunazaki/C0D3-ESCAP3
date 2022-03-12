using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerData data;
    public Item item;

    private bool onItem;

    void Update()
    {

        if (onItem && data.isInteracting)
        {
            data.inventory.AddItem(item.item, 1);
            Destroy(item.gameObject);
            onItem = false;
        }

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        var colItem = col.GetComponent<Item>();
        if (colItem)
        {
            onItem = true;
        }
    }

    private void OnApplicationQuit()
    {
        data.inventory.container.Clear();
    }
}
