using System;
using UnityEngine;

namespace _Scripts.Managers
{
    public class TutorialManager : MonoBehaviour
    {
        public GameObject[] popUps;
        private int popUpIndex;
        public InputHandler _inputHandler;

        public GameObject key;

        private void Update()
        {
            PopUpController();
        }

        private void PopUpController()
        {

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
                    popUps[popUpIndex].SetActive(true);
                    if (_inputHandler.isSprinting)
                    {
                        popUps[popUpIndex].SetActive(false);
                        popUpIndex++;
                    }

                    break;
                case 2:
                    popUps[popUpIndex].SetActive(true);
                    var tutorial = popUps[popUpIndex].GetComponent<Tutorial_3>();
                    if (tutorial.trigger == true)
                    {
                        popUps[popUpIndex].SetActive(false);
                        popUpIndex++;
                    }
                    break;
                case 3:
                    popUps[popUpIndex].SetActive(true);
                    key.SetActive(true);
                    if (_inputHandler.isInteracting)
                    {
                        popUps[popUpIndex].SetActive(false);
                        popUpIndex++;
                    }

                    break;
                case 4:
                    if (popUps[popUpIndex] == null) return;
                    popUps[popUpIndex].SetActive(true);

                    break;
            }

        }
    }
}