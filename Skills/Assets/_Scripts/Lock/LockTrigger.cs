using System;
using UnityEngine;

namespace _Scripts.Lock
{
    public class LockTrigger : MonoBehaviour
    {
        private AnimationHandler _anim;
        private InputHandler _inputHandler;

        private bool inTrigger;

        void Start()
        {
            _anim = GetComponent<AnimationHandler>();
            _inputHandler = InputHandler.instance;
        }

        private void Update()
        {
            if (inTrigger && _inputHandler.isInteracting)
            {
                _anim.ShowLock();
            }

            if (!inTrigger)
            {
                _anim.HideLock();
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                inTrigger = true;
            }
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                inTrigger = false;
            }
        }
    }
}