using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Animator animator;

    public CharacterController2D characterController2D;

    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(anim());
            characterController2D.m_Rigidbody2D.AddForce(new Vector2(0f, 1600f));
        }
    }

    IEnumerator anim()
    {
        animator.SetInteger("Jump", 1);
        
        _audioSource.Play();

        yield return new WaitForSeconds(1);

        animator.SetInteger("Jump", 0);

        _audioSource.Stop();
    }
}
