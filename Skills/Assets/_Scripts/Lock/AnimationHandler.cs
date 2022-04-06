using System;
using UnityEngine;

namespace _Scripts.Lock
{
    public class AnimationHandler : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void ShowLock()
        {
            _animator.SetBool("isOpen", true);
        }

        public void HideLock()
        {
            _animator.SetBool("isOpen", false);
        }
    }
}