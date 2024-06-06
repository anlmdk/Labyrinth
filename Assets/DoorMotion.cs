using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator anim;

    private string OPENED = "Opened";

    private Collider2D collider;

    private void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        DoorInteractive();
    }

    public void DoorInteractive()
    {
        if (GameManager.instance.checkKey is true)
        {
            anim.SetBool(OPENED, true);
            collider.isTrigger = true;
        }
        else
        {
            anim.SetBool(OPENED, false);
            collider.isTrigger = false;
        }
    }
}
