using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private Text txt;

    public static int count;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        txt.text = count + "/15";
    }
}
