using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownDoorTrigger : MonoBehaviour
{

    public TopDownDoor topDownDoor;

   private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            topDownDoor.inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            topDownDoor.inTrigger = false;
        }
    }
}
