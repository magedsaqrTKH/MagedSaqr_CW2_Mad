using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void ViewLeaderboard()
    {
        SceneManager.LoadSceneAsync(0);

    }
    
    public void BacktoMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Quit()
    {
        SceneManager.LoadSceneAsync(0);

    }
}


