using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    [SerializeField] private GameObject _icon;
    private PlayerInput _playerInput;

    private Vector2 boxSize = new Vector2(0.1f, 1f);

    void Awake()
    {
        _playerInput = new PlayerInput();
    }

    void OnEnable()
    {
        _playerInput.Enable();
    }

    void OnDisable()
    {
        _playerInput.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressed = _playerInput.Move.Interact.IsPressed();

        if (isPressed)
        {
            OnInteract();
        }

    }

    public void OpenIcon()
    {
        _icon.SetActive(true);
    }

    public void CloseIcon()
    {
        _icon.SetActive(false);
    }

    private void OnInteract()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0f, Vector2.zero);

        if (hits.Length > 0)
        {
            foreach (RaycastHit2D rc in hits)
            {
                if (rc.transform.GetComponent<Interactable>())
                {
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
    }
}
