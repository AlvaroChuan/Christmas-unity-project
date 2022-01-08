using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitCatch : MonoBehaviour
{
    private Animator animator;

    private AudioSource _audiosource;

    public bool ended;

    private Animation animation1;

    private bool catchable;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        _audiosource = gameObject.GetComponent<AudioSource>();
        animation1 = gameObject.GetComponent<Animation>();
        catchable = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.tag == "Player") && (catchable == true))
        {
            animator.SetTrigger("Catched");

            _audiosource.PlayOneShot(_audiosource.clip);

            UI.count += 1;

            catchable = false;

        }
    }

    void Update()
    {
        if (ended)
        {
            Destroy(gameObject);
        }    
    }
}
