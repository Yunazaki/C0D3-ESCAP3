using UnityEngine;
using UnityEngine.UI;
using System;

namespace _Scripts.Lock
{
    public class PushButton : MonoBehaviour
    {
        public static event Action<string> ButtonPressed = delegate { };

        private int dividerPosition;
        private string buttonName, buttonValue;
        private AudioManager _audioManager;

        void Start()
        {
            _audioManager = AudioManager.instance;
            buttonName = gameObject.name;
            dividerPosition = buttonName.IndexOf("_");
            buttonValue = buttonName.Substring(0, dividerPosition);
            
            gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
        }

        private void ButtonClicked()
        {
            ButtonPressed(buttonValue);
            
        }
    }
}