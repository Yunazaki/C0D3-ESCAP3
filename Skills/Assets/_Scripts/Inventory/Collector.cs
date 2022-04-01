using System;
using UnityEngine;

namespace _Scripts.Inventory
{
    public class Collector : MonoBehaviour
    {
        private InputHandler _inputHandler;
        private ICollectible _collectible;

        private bool canCollect;

        private void Start()
        {
            _inputHandler = GetComponent<InputHandler>();
        }

        private void Update()
        {
            Collect();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            _collectible = col.GetComponent<ICollectible>();
            if (_collectible != null)
            {
                canCollect = true;
            }
        }
        
        private void OnTriggerExit2D(Collider2D col)
        {
            _collectible = col.GetComponent<ICollectible>();
            if (_collectible != null)
            {
                canCollect = false;
            }
        }

        private void Collect()
        {
            if (_inputHandler.isInteracting && canCollect)
            {
                _collectible.Collect();
            }
        }
    }
}