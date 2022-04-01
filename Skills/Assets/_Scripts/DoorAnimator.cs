using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    private Animator anim;
    public BoxCollider2D _collider2D;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        anim.SetBool("isOpen", true);
        _collider2D.enabled = false;
    }

    public void CloseDoor()
    {
        anim.SetBool("isOpen", false);
        _collider2D.enabled = true;
    }
}
