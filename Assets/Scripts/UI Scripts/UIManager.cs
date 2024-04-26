using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
