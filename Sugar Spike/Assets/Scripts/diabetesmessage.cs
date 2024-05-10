using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


public class diabetesmessage : MonoBehaviour
{
    public TMP_Text gameOverText;
    public float messageDuration = 10f; // Duration of the message in seconds

    void Start()
    {
        StartCoroutine(ShowGameOverMessage());
    }

    IEnumerator ShowGameOverMessage()
    {
        // Display the game over message
        gameOverText.gameObject.SetActive(true);

        // Wait for the specified duration
        yield return new WaitForSeconds(messageDuration);

        // Hide the game over message
        gameOverText.gameObject.SetActive(false);

        // Optionally, load another scene or perform other actions after the message disappears
    }
}
