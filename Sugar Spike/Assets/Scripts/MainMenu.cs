using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void settingsgame()
    {
        SceneManager.LoadSceneAsync(8);

    }
    public void Logout()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Tips()
    {
        SceneManager.LoadSceneAsync(9);
    }
}
