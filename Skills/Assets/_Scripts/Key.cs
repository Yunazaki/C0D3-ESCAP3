using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Key : MonoBehaviour, ICollectible
{

    public static event HandleKeyCollected OnKeyCollected;
    public static event HandleKeyCollected OnKeyUse;

    public delegate void HandleKeyCollected(ItemData itemData);

    public ItemData key;

    public void Collect()
    {
        Destroy(gameObject);
        OnKeyCollected?.Invoke(key);
    }
}
