using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
   public InputField username;
   public void ButtonClick()
    {
        print(username.text);
        SceneManager.LoadScene("MainMenu");
    }
}
