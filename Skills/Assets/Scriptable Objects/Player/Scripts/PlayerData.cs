using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data")]
public class PlayerData : ScriptableObject
{

    public float playerSpeed = 5.0f;
    public float acceleration = 9f;
    public float decceleration = 9f;
    public float velPower = 1.2f;
    public float frictionAmount = 0.2f;

    public Vector2 moveDir;
    public bool isInteracting;
    public InventoryObject inventory;

}
