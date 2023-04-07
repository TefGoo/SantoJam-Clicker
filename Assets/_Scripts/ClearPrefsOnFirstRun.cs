using UnityEngine;
using UnityEngine.UI;

public class ClearPrefsOnFirstRun : MonoBehaviour
{
    public Button clearButton; // The button that clears PlayerPrefs
    private const string prefsClearedKey = "prefsCleared"; // The key to store whether PlayerPrefs have been cleared

    void Start()
    {
        // Check if PlayerPrefs have been cleared before
        if (!PlayerPrefs.HasKey(prefsClearedKey))
        {
            // If not, show the button and set its onClick event to clear PlayerPrefs
            clearButton.gameObject.SetActive(true);
            clearButton.onClick.AddListener(ClearPlayerPrefs);
        }
    }

    void ClearPlayerPrefs()
    {
        // Clear all PlayerPrefs and set the "prefsCleared" key to true
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt(prefsClearedKey, 1);

        // Hide the button
        clearButton.gameObject.SetActive(false);
    }
}
