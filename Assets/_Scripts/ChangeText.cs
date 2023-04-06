using UnityEngine;
using UnityEngine.Localization;

public class ChangeText : MonoBehaviour
{
    public LocalizedString localizedString;
    public TMPro.TMP_Text textObject;
    public float changeInterval = 5f;

    void Start()
    {
        InvokeRepeating("ChangeTextEveryInterval", 0f, changeInterval);
    }

    void ChangeTextEveryInterval()
    {
        textObject.text = localizedString.GetLocalizedString();
    }
}
