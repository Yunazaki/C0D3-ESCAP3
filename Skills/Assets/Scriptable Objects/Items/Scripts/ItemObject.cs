using UnityEngine;

public enum ItemType
{
    Key,
    Default
}

public class ItemObject : ScriptableObject
{

    public GameObject prefab;
    public ItemType type;

    [TextArea(10, 15)]
    public string description;

}
