using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Key : MonoBehaviour, ICollectible
{

    public static event Action OnKeyCollected;

    public void Collect()
    {
        Debug.Log("Key Collected");
        Destroy(gameObject);
        OnKeyCollected?.Invoke();
    }
}
