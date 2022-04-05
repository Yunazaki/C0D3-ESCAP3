using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Scripts.Inventory
{
    public class Inventory : MonoBehaviour
    {
        public List<InventoryItem> inventory = new List<InventoryItem>();

        private void OnEnable()
        {
            Items.Key.OnKeyCollected += Add;
        }
        
        private void OnDisable()
        {
            Items.Key.OnKeyCollected -= Add;
        }

        public void Add(ItemData itemData)
        {
            InventoryItem newItem = new InventoryItem(itemData); // Create a new inventory item
            inventory.Add(newItem);
        }

        public void Remove(InventoryItem item)
        {
            inventory.Remove(item);
        }
    }
}