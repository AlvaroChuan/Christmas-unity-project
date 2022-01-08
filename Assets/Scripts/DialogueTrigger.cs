using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;

	public bool started;

	public Animator anim;

	public bool right;

	private AudioSource _audioSource;

	public bool final;

	void Start()
	{
		started = false;
		_audioSource = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if ((started == false) && (collision.gameObject.tag == "Player"))
		{
			if (final)
			{
				FindObjectOfType<DialogueManager2>().StartDialogue(dialogue);
				
				started = true;
			}
			else
			{
				FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

				started = true;	
			}
			
		}
		
	}

	void Update()
	{
		if (right)
		{
			anim.SetTrigger("Right");
		}
	}

	 public void PlaySound()
	{
		_audioSource.Play();
	}
}
