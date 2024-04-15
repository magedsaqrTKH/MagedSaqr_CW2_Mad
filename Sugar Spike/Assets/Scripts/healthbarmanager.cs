using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    void Start()
    {

    }

    void Update()
    {
 
    }
    // OnTriggerEnter is called when the Collider other enters the trigger
        private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the trigger is with an object that should cause damage
        if (collision.gameObject.CompareTag("DamageObject"))
        {
            TakeSugar(5); // Adjust the damage amount as needed
        }
        else if (collision.gameObject.CompareTag("HealObject"))
        {
            Recover(5); // Adjust the damage amount as needed
        }
    }

    public void TakeSugar(float sugar)
    {
        healthAmount -= sugar;
        healthBar.fillAmount = healthAmount / 100f;
        if (healthAmount <= 0)
        {
            // Load the game over scene
            SceneManager.LoadScene(4);
        }
    }

    public void Recover(float healAmount)
    {
        healthAmount += healAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        healthBar.fillAmount = healthAmount / 100f;
    }
}
