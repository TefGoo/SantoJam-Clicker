using UnityEngine;
using UnityEngine.Localization;

public class LocalizedText : MonoBehaviour
{
    public LocalizedString localizedString;

    void Start()
    {
        // Validate the localized string
        localizedString.StringChanged += UpdateText;
    }

    void OnDestroy()
    {
        // Remove the event handler to avoid memory leaks
        localizedString.StringChanged -= UpdateText;
    }

    void UpdateText(string value)
    {
        // The localized string is automatically updated by the Localization system
    }
}
