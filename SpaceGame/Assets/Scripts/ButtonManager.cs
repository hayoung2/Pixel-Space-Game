using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject setting;

    public void OpenSetting()
    {
        setting.SetActive(true);
    }

    public void ExitSetting()
    {
        setting.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
