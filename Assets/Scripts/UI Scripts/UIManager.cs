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
        GameObject projectsView = GameObject.Find("ProjectsViewContent"); 
        Instantiate(Resources.Load("Project"), projectsView.transform);

        //SceneManager.LoadScene("ProjectScene");
    }
}
