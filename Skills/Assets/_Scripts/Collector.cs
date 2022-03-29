using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    private InputHandler inputHandler;
    private ICollectible collectible;

    private bool canCollect;

    void Start()
    {
        inputHandler = GetComponent<InputHandler>();
    }

    void Update()
    {
        Collect();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        collectible = col.GetComponent<ICollectible>();
        if (collectible != null)
        {
            Debug.Log("Can Collect");
            canCollect = true;
        }
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        collectible = col.GetComponent<ICollectible>();
        if (collectible != null)
        {
            canCollect = false;
        }
    }

    private void Collect()
    {
        if (inputHandler.inputActions.PlayerMovement.Interact.WasPressedThisFrame())
        {
            if (canCollect)
            {
                collectible.Collect();
            }
        }
    }

}
