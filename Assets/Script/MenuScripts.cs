using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour {
    public void PlayGame()
    {
        GuiScreen.points = 0;
        SceneManager.LoadScene("GameGame");
    }
    public void BackToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }
    public void HelpScreen()
    {
        SceneManager.LoadScene("HelpMenu");
    }
    public void GotoCredits()
    {
        SceneManager.LoadScene("Credits");
    }


    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
