using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMusic : MonoBehaviour
{
    public MusicClass musicClass;

    private GameObject music;

    public bool final;

    void Start()
    {
        music = GameObject.Find("Music 1");
        Destroy(music);
        music = GameObject.Find("Music");
        Destroy(music);
        if (final)
        {
            music = GameObject.Find("Music 2");
            Destroy(music);
        }
        musicClass.PlayMusic();
    }
}
