using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts
{
    public class LevelTransition : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}