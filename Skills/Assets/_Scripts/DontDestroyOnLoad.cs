using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public string objectID;
    void Awake()
    {

        objectID = name + transform.position.ToString();
        
        var findDontDestroy = Object.FindObjectsOfType<DontDestroyOnLoad>();
        for (int i = 0; i < findDontDestroy.Length; i++)
        {
            if (findDontDestroy[i] != this)
            {
                if (findDontDestroy[i].objectID == objectID)
                {
                    Destroy(gameObject);
                }
            }
        }

        DontDestroyOnLoad(gameObject);
    }

}
