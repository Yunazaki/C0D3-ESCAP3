using System;
using UnityEngine;

namespace _Scripts.Inventory
{
    public class Use : MonoBehaviour
    {

        public bool isTrigger;
        private ICollectible _collectible;

        void Update()
        {
            UseItem();
        }
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Finish"))
            {
                Debug.Log("Trigger");
                isTrigger = true;
            }
        }
        
        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.CompareTag("Finish"))
            {
                isTrigger = false;
            }
        }

        private void UseItem()
        {
            if (isTrigger)
            {
                _collectible.Use();
            }
        }
        
    }
}