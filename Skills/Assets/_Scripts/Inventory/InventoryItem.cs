using System;
using UnityEngine;

namespace _Scripts.Inventory
{
    [Serializable]
    public class InventoryItem
    {
        public ItemData itemData;

        public InventoryItem(ItemData item)
        {
            itemData = item;
        }
    }
}