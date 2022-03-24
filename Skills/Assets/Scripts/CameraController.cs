using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            Debug.Log("active");
            gameObject.SetActive(true);
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            Debug.Log("unactive");
            gameObject.SetActive(false);
        }

    }

}
