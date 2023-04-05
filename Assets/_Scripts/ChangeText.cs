using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public string[] texts;
    public TMP_Text textObject;

    void Start()
    {
        InvokeRepeating("ChangeTextEvery20Seconds", 0f, 20f);
    }

    void ChangeTextEvery20Seconds()
    {
        int index = Random.Range(0, texts.Length);
        textObject.text = texts[index];
    }
}
