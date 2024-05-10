using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class fruitcounter : MonoBehaviour
{
    public static fruitcounter instance;
    public TMP_Text fruitText;
    public int currentFruits = 0;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        fruitText.text = "Fruits: " + currentFruits.ToString();
    }
    public void increaseFruits(int v)
    {
        currentFruits += v;
        fruitText.text = "Fruits: " + currentFruits.ToString();
        if (currentFruits >= 10)
        {
            SceneManager.LoadScene(5);
        }
    }
}
