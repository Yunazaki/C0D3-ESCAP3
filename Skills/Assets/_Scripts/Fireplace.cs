using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{

    private Animator _anim;
    private BoxCollider2D _col;
    public GameObject key;

    public int racksActivated;
    private bool hasSpawned;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckRacks();
    }

    private void CheckRacks()
    {
        if (racksActivated != 2) return;

        _anim.SetTrigger("rackTriggered");
        _col.enabled = false;

        if (!hasSpawned)
        {
            Instantiate(key, transform.position, Quaternion.identity);
            hasSpawned = true;
        }
    }
}
