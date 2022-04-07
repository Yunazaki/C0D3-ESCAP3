using System.Collections;
using System.Collections.Generic;
using _Scripts.Inventory;
using UnityEngine;

public class TopDownDoor : MonoBehaviour
{

    private InputHandler _inputHandler;
    public GameObject layer;
    public Inventory _inventory;
    public InventoryItem key;
    public bool inTrigger;
    private bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        _inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        CheckKey(key);

        if (inTrigger && hasKey && _inputHandler.isInteracting)
        {
            layer.SetActive(true);
            Destroy(gameObject);
        }
    }

     private void CheckKey(InventoryItem key)
    {
        for (int i = 0; i < _inventory.inventory.Count; i++)
        {
            if (key.itemData.name.Contains(key.itemData.name))
            {
                hasKey = true;
            }
            else
            {
                hasKey = false;
            }
        }
    }
}
