using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoatRackTrigger : MonoBehaviour
{

    private SpriteRenderer _spriteRenderer;
    private InputHandler _inputHandler;
    public Fireplace fireplace;
    public Sprite sprite;

    private bool isTrigger;
    private bool isActivated;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _inputHandler = InputHandler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrigger && _inputHandler.isInteracting)
        {
            ActivateCoatRack();
        }
    }

    public void ActivateCoatRack()
    {
        if (isActivated == true) return;
        _spriteRenderer.sprite = sprite;
        isActivated = true;
        fireplace.racksActivated++;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isTrigger = false;
        }
    }
}
