using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreButtons : MonoBehaviour
{
    public void Returntomenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void ReturntoSignup()
    {
        SceneManager.LoadSceneAsync(2);

    }
    public void ReturntoLogin()
    {
        SceneManager.LoadSceneAsync(1);

    }
}
