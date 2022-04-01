using UnityEngine;

namespace _Scripts.Inventory
{
    public class Item
    {

        public enum ItemType
        {
            Key
        }

        public ItemType itemType;
        public int amount;

    }
}