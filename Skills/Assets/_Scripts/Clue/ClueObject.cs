using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueObject : MonoBehaviour
{

    public GameObject _gameObject;
    // Start is called before the first frame update
    void Start()
    {
        _gameObject.SetActive(false);
    }

    public void OpenCanvas()
    {
        _gameObject.SetActive(true);
    }

    public void CloseCanvas()
    {
        _gameObject.SetActive(false);
    }
}
