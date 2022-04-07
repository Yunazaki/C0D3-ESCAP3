using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTrigger : MonoBehaviour
{
    public GameObject layer;
    public GameObject code;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            layer.SetActive(true);
            code.SetActive(true);
        }
    }
}
