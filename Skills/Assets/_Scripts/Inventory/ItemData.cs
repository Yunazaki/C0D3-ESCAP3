using UnityEngine;

namespace _Scripts.Inventory
{
    [CreateAssetMenu(fileName = "Item Data", menuName = "Item Data", order = 0)]
    public class ItemData : ScriptableObject
    {
        public string displayName;
        public Sprite Icon;
    }
}