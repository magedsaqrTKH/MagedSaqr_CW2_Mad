using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class medicinecounter : MonoBehaviour
{
    public static medicinecounter instance;
    public TMP_Text medText;
    public int currentMeds = 0;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        medText.text = "Medicine: " + currentMeds.ToString();
    }
    public void increaseHeals(int v)
    {
        currentMeds += v;
        medText.text = "Medicine: " + currentMeds.ToString();
        if (currentMeds >= 50)
        {
            SceneManager.LoadScene(6);
        }
    }
}
