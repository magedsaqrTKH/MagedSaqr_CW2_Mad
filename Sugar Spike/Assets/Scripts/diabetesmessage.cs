using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


public class diabetesmessage : MonoBehaviour
{
    public TMP_Text gameOverText;
    public float messageDuration = 10f; 

    void Start()
    {
        StartCoroutine(ShowGameOverMessage());
    }

    IEnumerator ShowGameOverMessage()
    {
      
        gameOverText.gameObject.SetActive(true);

        
        yield return new WaitForSeconds(messageDuration);

        
        gameOverText.gameObject.SetActive(false);

        
    }
}
