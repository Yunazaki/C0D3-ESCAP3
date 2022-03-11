using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PickUp : Interactable
{
    public override void Interact()
    {
        gameObject.SetActive(false);
    }

    public Sprite open;
    public Sprite close;

    private SpriteRenderer sr;

    private bool isOpen;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }



}
