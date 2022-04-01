using System;
using _Scripts.Inventory;
using UnityEngine;

namespace _Scripts.Items
{
    public class Key : MonoBehaviour, ICollectible
    {
        public static event HandleKeyCollected OnKeyCollected;

        public delegate void HandleKeyCollected(ItemData itemData);

        public ItemData keyData;

        public void Collect()
        {
            Destroy(gameObject);
            OnKeyCollected?.Invoke(keyData);
        }
    }
}