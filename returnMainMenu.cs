using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnMainMenu : MonoBehaviour
{
    public void returnButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
