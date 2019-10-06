using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    Animator animator;
    bool doorOpen;

    private void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorOpen = true;
            DoorControl("Open");
        }
    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);
    }

    private void OnTriggerExit(Collider other)
    {
        if(doorOpen)
        {
            doorOpen = false;
            DoorControl("Close");
        }
    }
}
