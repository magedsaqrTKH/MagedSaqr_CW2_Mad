using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Logingame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void SignUpgame()
    {
        SceneManager.LoadSceneAsync(2);

    }
}
