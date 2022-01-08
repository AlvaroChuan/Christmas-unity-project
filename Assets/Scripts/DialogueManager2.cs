using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager2 : MonoBehaviour {

	public DialogueTrigger dialogueTrigger;
	public Text dialogueText;

	public Animator dialogueanimator;

	public Animator characteranimator;

	public Rigidbody2D character;

	private Queue<string> sentences;

	public GameObject NPC;

	public GameObject DialogueCanvas;

	public SceneModifier sceneModifier;

	private AudioSource _audioSource;

    public LevelLoader levelLoader;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		_audioSource = GetComponent<AudioSource>();
	}

	public void StartDialogue (Dialogue dialogue)
	{
		character.constraints = RigidbodyConstraints2D.FreezeAll;

		dialogueanimator.SetInteger("State", 1);

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		_audioSource.Play();
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
		_audioSource.Stop();
	}

	public void EndDialogue()
	{
		dialogueanimator.SetInteger("State", 2);
		character.constraints = RigidbodyConstraints2D.None;
		character.constraints = RigidbodyConstraints2D.FreezeRotation;
		characteranimator.SetTrigger("Ended");
		Destroy(NPC, 1);
		Destroy(gameObject, 1);
        levelLoader.level = 7;
        levelLoader.loadNextLevel();

	}

}
