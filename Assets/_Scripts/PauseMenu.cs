using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public Button pauseButton;

    void Start()
    {
        pauseButton.onClick.AddListener(TogglePauseMenu);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        bool isPaused = !pauseMenuCanvas.activeSelf;
        pauseMenuCanvas.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
    }

    public void HidePauseMenu()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
