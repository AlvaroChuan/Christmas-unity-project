using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class MusicClass : MonoBehaviour
 {
     private AudioSource _audioSource;

     public bool finallevel;

     public static bool playing;

     public bool final;
     private void Awake()
     {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        PlayMusic();
     }
 
     public void PlayMusic()
     {
         if (!playing){
             _audioSource.Play();
             playing = true;
         }

     }
 
     public void StopMusic()
     {
         _audioSource.Stop();
     }

     void Update()
     {
         if (finallevel)
         {
             playing = false;
             PlayMusic();
             finallevel = false; 
         }
         else if (final)
         {
             playing = false;
             PlayMusic();
             final = false;
         }
     }
 }
