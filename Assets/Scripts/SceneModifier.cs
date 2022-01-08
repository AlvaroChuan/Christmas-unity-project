using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneModifier : MonoBehaviour
{
    public static int stage = 0;

    public Animator animator;

    public GameObject NPC;

    public GameObject Music;

    void Start()
    {
        if (stage != 0)
        {
            open_gate();
            Destroy(NPC);
            Destroy(Music);
        }
    }

    public void open_gate()
    {
        animator.SetInteger("Stage", stage);
    }
}
