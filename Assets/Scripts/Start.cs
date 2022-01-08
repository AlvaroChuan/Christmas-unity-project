using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public LevelLoader levelLoader;
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Loadlevel.counter += 1;
            levelLoader.level += 1;
            levelLoader.loadNextLevel();
        }
    }
}
