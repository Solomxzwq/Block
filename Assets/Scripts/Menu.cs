using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
     
public class Menu : MonoBehaviour
{
    public GameObject settingsPanel;
    public void PlayGame()
    {
        Application.LoadLevel("LVL 1");
        print("StartPress");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void SettingPanel()
    {
        settingsPanel.SetActive(true);
    }
    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
}
