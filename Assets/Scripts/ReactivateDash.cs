using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactivateDash : MonoBehaviour
{
public PlayerMovement playerMovement;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerMovement.candash = true;
        }
    }
}
