using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
    public Slider LoadingProcess;
    private int CurProcess = 0;
    private void FixedUpdate()
    {
        if (CurProcess < 100)
        {
            CurProcess++;
            LoadingProcess.value = CurProcess;
        }
        else
        {
            SceneManager.LoadScene("Login");
        }
    }
}
