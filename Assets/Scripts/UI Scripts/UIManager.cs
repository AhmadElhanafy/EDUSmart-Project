using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ExitAppButton()
    { 
        Application.Quit();
    }

    public void SettingsButton()
    {
        Debug.Log("Settings button pressed");
    }

    public void OpenProjectScene()
    {
        SceneManager.LoadScene("ProjectScene");
    }
}
