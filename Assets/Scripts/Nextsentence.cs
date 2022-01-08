using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextsentence : MonoBehaviour
{

    DialogueManager dialogueManager;

    DialogueTrigger dialogueTrigger;

    DialogueManager2 dialogueManager2;

    public bool final;

    void Start()
    {
        if (final)
        {
            dialogueManager2 = FindObjectOfType<DialogueManager2>();
        }
        else
        {
            dialogueManager = FindObjectOfType<DialogueManager>();
        }
        
        dialogueTrigger = FindObjectOfType<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Jump")) && (dialogueTrigger.started == true))
        {
            if (final)
            {
                dialogueManager2.DisplayNextSentence();
            }
            else
            {
             dialogueManager.DisplayNextSentence();
            }
        }
    }
}
