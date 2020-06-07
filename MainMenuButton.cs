using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void startButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void optionButtionClick()
    {
        SceneManager.LoadScene("Option");
    }
    public void quitButtonClick()
    {
        Application.Quit();
    }
}
