using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InventoryObject inventory;

    public void OnTriggerEnter2D(Collider2D col)
    {
        var item = col.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(col.gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        inventory.container.Clear();
    }
}
