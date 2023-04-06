using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;

public class ChangeText : MonoBehaviour
{
    public LocalizedString[] localizedStrings;
    public TMP_Text textObject;
    public float changeInterval = 5f;

    void Start()
    {
        InvokeRepeating("ChangeTextEvery20Seconds", 0f, changeInterval);
    }

    void ChangeTextEvery20Seconds()
    {
        int index = Random.Range(0, localizedStrings.Length);
        textObject.text = localizedStrings[index].GetLocalizedString();
    }
}
