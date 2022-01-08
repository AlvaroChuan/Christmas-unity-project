using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Animator animator;

    private AudioSource _audioSource;

    private int counter;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (counter == 0)
            {
                _audioSource.Play();
                _audioSource.Play();
                animator.SetTrigger("Activated");
                CharacterController2D.position = gameObject.transform.position;
                counter += 1;
            }
        }
    }
}
