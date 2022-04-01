using System;
using UnityEngine;

namespace _Scripts.Managers
{
    public class TutorialManager : MonoBehaviour
    {
        public GameObject[] popUps;
        private int popUpIndex;
        public InputHandler _inputHandler;

        private void Update()
        {

            for (int i = 0; i < popUps.Length; i++)
            {
                if (i == popUpIndex)
                {
                    popUps[popUpIndex].SetActive(true);
                }
                else
                {
                    popUps[popUpIndex].SetActive(false);
                }
            }

            switch (popUpIndex)
            {
                case 0:
                    if (Mathf.Abs(_inputHandler.horizontal) > 0.01f || Mathf.Abs(_inputHandler.vertical) > 0.01f)
                    {
                        popUpIndex++;
                    }

                    break;
                case 1:
                    if (_inputHandler.isSprinting)
                    {
                        popUpIndex++;
                    }

                    break;
            }
            
        }
    }
}