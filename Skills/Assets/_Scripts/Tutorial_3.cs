using System;
using UnityEngine;

namespace _Scripts
{
    public class Tutorial_3 : MonoBehaviour
    {
        public bool trigger;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                trigger = true;
            }
        }
    }
}