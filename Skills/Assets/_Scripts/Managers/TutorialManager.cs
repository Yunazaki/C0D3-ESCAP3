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
            PopUpController();
        }

        private void PopUpController()
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
                    popUps[popUpIndex].SetActive(true);
                    if (Mathf.Abs(_inputHandler.horizontal) > 0.01f || Mathf.Abs(_inputHandler.vertical) > 0.01f)
                    {
                        Debug.Log("Increasing Index");
                        popUps[popUpIndex].SetActive(false);
                        popUpIndex++;
                    }

                    break;
                case 1:
                    if (_inputHandler.isSprinting)
                    {
                        Debug.Log("Increasing Index");
                        popUpIndex++;
                    }

                    break;
                case 2:

                    break;
            }

        }
    }
}