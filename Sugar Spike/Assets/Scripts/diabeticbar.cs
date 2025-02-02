using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class diabeticbar : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public ParticleSystem healParticlePrefab;
    Audiomanager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
    }

    void Start()
    {
        ParticleSystem particleSystemInstance = Instantiate(healParticlePrefab, transform.position, Quaternion.identity);

        
        particleSystemInstance.Play();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
      
        if (collision.gameObject.CompareTag("DamageObject"))
        {
            TakeSugar(100);
            audioManager.SoundEffects(audioManager.eatCandy);

        }
        else if (collision.gameObject.CompareTag("HealObject"))
        {
            Recover(0);
            audioManager.SoundEffects(audioManager.healSound);

            if (healParticlePrefab != null)
            {
                Instantiate(healParticlePrefab, collision.transform.position, Quaternion.identity);
                healParticlePrefab.Play();
            }

        }
    }

    public void TakeSugar(float sugar)
    {
        healthAmount -= sugar;
        healthBar.fillAmount = healthAmount / 100f;
        if (healthAmount <= 0)
        {
            
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
