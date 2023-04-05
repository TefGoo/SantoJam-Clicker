using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isPaused = !pauseMenuCanvas.activeSelf;
            pauseMenuCanvas.SetActive(isPaused);
        }
    }

    public void HidePauseMenu()
    {
        pauseMenuCanvas.SetActive(false);
    }
}
