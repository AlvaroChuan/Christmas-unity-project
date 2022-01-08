using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel : MonoBehaviour
{
    public LevelLoader levelLoader;

    public SceneModifier sceneModifier;

    public static int counter;

    public bool final;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Player"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                levelLoader.level = (counter + 1);
                levelLoader.loadNextLevel();
            }

            else if ((final) && (collision.gameObject.tag == "Player"))
            {
                levelLoader.level = 6;
                levelLoader.loadNextLevel();
            }
            else
            {
                counter = SceneManager.GetActiveScene().buildIndex;
                levelLoader.level = 1;
                levelLoader.loadNextLevel();
                SceneModifier.stage += 1;
                sceneModifier.open_gate();
            }
            
        }
    }
}
