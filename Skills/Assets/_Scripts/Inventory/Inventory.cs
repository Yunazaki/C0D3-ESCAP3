using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static event Action<List<InventoryItem>> onInventoryChange;

    public List<InventoryItem> inventory = new List<InventoryItem>();
    private Dictionary<ItemData, InventoryItem> itemDictionary = new Dictionary<ItemData, InventoryItem>();

    private void OnEnable()
    {
        Key.OnKeyCollected += Add;
        Key.OnKeyUse += Remove;
    }

    private void OnDisable()
    {
        Key.OnKeyCollected -= Add;
        Key.OnKeyUse -= Remove;
    }

    private void Add(ItemData itemData)
    {
        if (itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            item.AddToCount();
            Debug.Log($"{item.itemData.displayName} total stack is now {item.itemCount}.");
            onInventoryChange?.Invoke(inventory);
        }
        else
        {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($"Added {newItem.itemData.displayName}.");
            onInventoryChange?.Invoke(inventory);
        }
    }

    private void Remove(ItemData itemData)
    {
        if (itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            item.RemoveFromCount();
            if (item.itemCount == 0)
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
            onInventoryChange?.Invoke(inventory);
        }
    }
    
}
