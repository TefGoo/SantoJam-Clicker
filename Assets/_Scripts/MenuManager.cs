using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Aplication Closing...");
    }
}
